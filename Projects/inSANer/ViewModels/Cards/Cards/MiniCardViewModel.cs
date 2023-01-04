using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inSANer.ViewModels.Cards.Cards
{
    internal class MiniCardViewModel : ObservableObject
    {
        public string Title { get; set; }
        public string Description { get; set; }
    }
}
