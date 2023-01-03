using inSANer.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inSANer.Models
{
    // for ScenarioCardFile & MiniCard & DetailCards (4 kinds of them)
    internal class Scenario
    {
        public List<CardFolder> SubFolders { get; set; }

        public ScenarioExplorerViewModel Explorer { get; set; }


    }
}
