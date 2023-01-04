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

        [RelayCommand]
        public void CreateScenario()
        {
            MessageBox.Show("Create Btn");
        }
    }
}
