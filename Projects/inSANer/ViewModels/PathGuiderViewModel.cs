using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inSANer.ViewModels
{
    internal class PathGuiderViewModel : ObservableObject
    {
        public object AddressBar { get; set; }

        // 이게 있어서 시나리오마다 PathGuide가 있어야 함
        private Stack<string> pathHistoryForForwardAndBackward;

    }
}
