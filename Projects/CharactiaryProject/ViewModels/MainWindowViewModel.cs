﻿using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace CharactiaryProject.ViewModels
{
    internal partial class MainWindowViewModel : ObservableObject
    {
        [RelayCommand]
        void Test()
        {
            MessageBox.Show("Tedt Command");
        }
    }
}
