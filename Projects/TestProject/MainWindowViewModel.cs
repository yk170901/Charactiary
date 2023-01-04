using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using WpfLibrary1;

namespace TestProject;

public record class UserLoggedIn(string UserName);

// [ObservableObject] // IRecipient Already Inherits ObservableObject
[ObservableRecipient]
public partial class MainWindowViewModel : ObservableValidator, IRecipient<UserLoggedIn>
{
    // Dependency Injection 및 MVVM Community Toolkit Educating Videos on Youtube

    // https://www.youtube.com/watch?v=j3pl2tkBM1A

    private readonly IDataAccess _dataAccess;

    public MainWindowViewModel(IDataAccess dataAcess)
    {
        // INavigationService test = new();

        _dataAccess = dataAcess;
        var t = Messenger;
        this.Messenger = new StrongReferenceMessenger();

        Messenger.Register<UserLoggedIn>(this);
    }

    private void Foo()
    {
        Messenger.Send(new UserLoggedIn("Ava"));
        Messenger.Unregister<UserLoggedIn>(this);
    }

    public void Receive(UserLoggedIn message)
    {
        MessageBox.Show(message.UserName);
    }


    private bool CanClick() => FirstName == "Kevin";

    [RelayCommand(IncludeCancelCommand = true, AllowConcurrentExecutions = true)] // CanExecute=nameof(CanClick) // AllowConcurrentExecutions = true (send cancellation token) // IncludeCancelCommand =true
    private async Task Click(CancellationToken token) // Task!
    {
        try
        {
            await Task.Delay(5_000, token);
            FirstName += " Robert";
        }
        catch (OperationCanceledException)
        {
            Foo();
            FirstName += " x ";
        }
    }

    [ObservableProperty]
    [NotifyCanExecuteChangedFor(nameof(ClickCommand))]
    private string _firstName = "Kevin";

    [ObservableProperty]
    [MinLength(2)]
    [EmailAddress]
    private string _text = "dd";


    [ObservableProperty]
    private string _getDataText = "text";

    public IDataAccess DataAcess { get; }

    [RelayCommand]
    void GetData()
    {
        GetDataText += _dataAccess.WriteData();
    }

    partial void OnFirstNameChanging(string value)
    {
        MessageBox.Show(value);
    }

}