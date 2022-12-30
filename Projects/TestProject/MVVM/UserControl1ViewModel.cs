using CommunityToolkit.Mvvm.ComponentModel;
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
    internal partial class UserControl1ViewModel : IRecipient<TextMessage>
    {
        public UserControl1ViewModel()
        {
            WeakReferenceMessenger.Default.Register<TextMessage>(this);
        }

        [ObservableProperty]
        private string _name1 = "default text";

        public void Receive(TextMessage message)
        {
            MessageBox.Show("Received by 1");
            Name1 = message.Value;
        }
    }
}
