using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SingleModel.Model;

namespace SingleModel.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            Game game = new Game
            {
                Name = "World of Warcraft ",
                Platform = "PC",
                Engine = "Unknown"
            };
            return View(game);
        }
    }
}