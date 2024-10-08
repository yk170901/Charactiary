﻿using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace inSANer.ViewModels.Cards.Containers
{
    internal partial class CardContainerViewModel : ObservableObject
    {
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

        public CardContainerViewModel()
        {
            MiniCardContainerVM = new();
            DetailCardContainerVM = new();
        }
    }
}
