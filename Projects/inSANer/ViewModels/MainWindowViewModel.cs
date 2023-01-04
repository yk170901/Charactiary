using CommunityToolkit.Mvvm.ComponentModel;
using inSANer.ViewModels.Cards.Containers;
using inSANer.ViewModels.ScenarioExplorer;
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
        private ScenarioExplorerViewModel _scenarioExplorerVM;

        [ObservableProperty]
        private PathGuiderViewModel _pathGuiderVM;

        [ObservableProperty]
        private CardContainerViewModel _cardContainerVM;

        public MainWindowViewModel()
        {
            TopBarVM = new();
            PathGuiderVM = new();
            CardContainerVM = new();
            ScenarioExplorerVM = new();
        }
    }
}
