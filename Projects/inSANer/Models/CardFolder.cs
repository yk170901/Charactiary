using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inSANer.Models
{
    // for ScenarioCardFolder & MiniCardContainer(+MiniCard)
    internal class CardFolder
    {
        public List<CardFile> SubFiles { get; set; }
    }
}
