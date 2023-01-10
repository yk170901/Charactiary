using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace inSANer.ViewModels.ScenarioExplorer
{
    internal partial class ScenarioExplorerViewModel : ObservableObject
    {
        // Style Button https://www.codeproject.com/Questions/1279786/Changing-triangle-toggleicon-to-arrow-in-treeview
        // Josh https://www.codeproject.com/Articles/17025/Custom-TreeView-Layout-in-WPF
        //https://social.msdn.microsoft.com/Forums/en-US/2ad2798b-712d-4ae2-b259-5041a61054c6/how-to-create-a-custom-hierarchical-wpf-treeview?forum=wpf
        // https://stackoverflow.com/questions/47622013/how-to-change-hierarchicaldatatemplate

        [RelayCommand]
        public void CreateScenario()
        {
            MessageBox.Show("Create Btn");
        }
    }
}
