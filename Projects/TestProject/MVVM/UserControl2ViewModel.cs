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
    internal partial class UserControl2ViewModel : IRecipient<TextMessage>
    {
        public UserControl2ViewModel()
        {
            WeakReferenceMessenger.Default.Register<TextMessage>(this, (r, m) =>
            {
                MessageBox.Show("Custom Receiver by 2 " + m.Value);
            });

        }

        [ObservableProperty]
        private string _name2 = "default text";

        public void Receive(TextMessage message)
        {
            MessageBox.Show("Received by 2");

            Name2 = message.Value;
        }
    }
}
