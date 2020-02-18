using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ViewModelsTest.Model;

namespace ViewModelsTest.ViewModel
{
    public class GameViewModel
    {
        public IEnumerable<PCGame> PCGames { get; set; }
        public IEnumerable<XBoxGame> XBoxGames { get; set; }
    }
}
