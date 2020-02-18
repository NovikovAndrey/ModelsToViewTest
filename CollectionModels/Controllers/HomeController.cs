using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CollectionModels.Model;
using Microsoft.AspNetCore.Mvc;

namespace CollectionModels.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            Game game = new Game
            {
                Name = "World of warcraft",
                Engine = "PC",
                Platform = "Unknow"
            };
            Game game1 = new Game
            {
                Name = "Heroes of storm",
                Engine = "PC",
                Platform = "Unknow"
            };
            Game game2 = new Game
            {
                Name = "Diablo",
                Engine = "PC",
                Platform = "Unknow"
            };
            List<Game> collectionGames = new List<Game>();
            collectionGames.Add(game);
            collectionGames.Add(game1);
            collectionGames.Add(game2);
            return View(collectionGames);
        }
    }
}