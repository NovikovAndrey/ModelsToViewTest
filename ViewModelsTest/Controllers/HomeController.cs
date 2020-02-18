using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ViewModelsTest.Model;
using ViewModelsTest.ViewModel;

namespace ViewModelsTest.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            PCGame pCGame = new PCGame
            {
                Company = "Blizzard",
                Name="World of warcraft"
            };
            PCGame pCGame1 = new PCGame
            {
                Company = "Blizzard",
                Name = "Overwatch"
            };
            PCGame pCGame2 = new PCGame
            {
                Company = "Blizzard",
                Name = "Diablo"
            };

            XBoxGame xBoxGame = new XBoxGame
            {
                Company ="Valve",
                Name="Dota"
            };
            XBoxGame xBoxGame1 = new XBoxGame
            {
                Company = "Valve",
                Name = "Rocket"
            };
            XBoxGame xBoxGame2 = new XBoxGame
            {
                Company = "Valve",
                Name = "CS"
            };

            List<PCGame> pCGames = new List<PCGame>();
            pCGames.Add(pCGame);
            pCGames.Add(pCGame1);
            pCGames.Add(pCGame2);

            List<XBoxGame> xBoxGames = new List<XBoxGame>();
            xBoxGames.Add(xBoxGame);
            xBoxGames.Add(xBoxGame1);
            xBoxGames.Add(xBoxGame2);

            GameViewModel gameViewModel = new GameViewModel()
            {
                PCGames = pCGames,
                XBoxGames = xBoxGames
            };

            return View(gameViewModel);
        }
    }
}