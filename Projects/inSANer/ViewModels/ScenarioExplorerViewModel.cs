using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

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

        [ObservableProperty]
        private Visibility detailVisibility = Visibility.Collapsed;


        // Trigger This From 
        // (1) MiniCardContainer (Double Click on MiniCard)
        // (2) DetailCardContainer (Close Button)
        [RelayCommand]
        void ChangeDetailCardVisibility()
        {
            DetailVisibility = DetailVisibility == Visibility.Visible ? Visibility.Collapsed : Visibility.Visible;
        }

        public ScenarioExplorerViewModel()
        {
            PathGuiderVM = new();
            MiniCardContainerVM = new();
            DetailCardContainerVM = new();
        }
    }
}
