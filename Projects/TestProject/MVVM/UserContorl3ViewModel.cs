using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using TestProject.Messenger;

namespace TestProject.MVVM
{
    [ObservableObject]
    internal partial class UserContorl3ViewModel // Not a Recipient
    {
        public UserContorl3ViewModel()
        {

        }

        [RelayCommand]
        void ChangeText()
        {
            WeakReferenceMessenger.Default.Send<TextMessage>(new TextMessage(DateTime.Now.ToString("mmss")));
        }
    }
}
