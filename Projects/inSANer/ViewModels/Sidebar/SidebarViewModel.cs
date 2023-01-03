﻿using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace inSANer.ViewModels.Sidebar
{
    internal partial class SidebarViewModel : ObservableObject
    {
        public SidebarViewModel()
        {


        }

        [RelayCommand]
        public void CreateScenario()
        {
            MessageBox.Show("Create Btn");
        }
    }
}
