using CommunityToolkit.Mvvm.ComponentModel;
using inSANer.ViewModels.Sidebar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace inSANer.ViewModels
{
    internal partial class MainWindowViewModel : ObservableObject
    {
        [ObservableProperty]
        private TopBarViewModel _topBarVM;

        [ObservableProperty]
        private SidebarViewModel _sidebarVM;

        [ObservableProperty]
        private PathGuiderViewModel _pathGuiderVM;

        [ObservableProperty]
        private ScenarioExplorerViewModel _scenarioExplorerVM;

        public MainWindowViewModel()
        {
            _topBarVM = new();
            SidebarVM = new();
            PathGuiderVM = new();
            ScenarioExplorerVM = new();
        }
    }
}
