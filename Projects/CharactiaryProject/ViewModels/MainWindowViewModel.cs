using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls.Primitives;

namespace CharactiaryProject.ViewModels
{
    internal partial class MainWindowViewModel : ObservableObject
    {
        [RelayCommand]
        void Test()
        {
            MessageBox.Show("Test Command");
        }

        public void OnDragCompleted(object sender, DragCompletedEventArgs e)
        {
            MessageBox.Show(e.HorizontalChange.ToString());
        }
    }
}
