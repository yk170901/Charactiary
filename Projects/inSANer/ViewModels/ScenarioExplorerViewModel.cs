using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inSANer.ViewModels
{
    internal partial class ScenarioExplorerViewModel : ObservableObject
    {
        [ObservableProperty]
        private PathGuiderViewModel _pathGuiderVM;

        [ObservableProperty]
        private MiniCardContainerViewModel _miniCardContainerVM;

        [ObservableProperty]
        private DetailCardContainerViewModel _detailCardContainerVM;

        public ScenarioExplorerViewModel()
        {
            PathGuiderVM = new();
            MiniCardContainerVM = new();
            DetailCardContainerVM = new();
        }
    }
}
