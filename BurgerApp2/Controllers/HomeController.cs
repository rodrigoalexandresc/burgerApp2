using BurgerApp2.Domain;
using BurgerApp2.Domain.Cardapio;
using BurgerApp2.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace BurgerApp2.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index([FromServices] ICardapioService cardapioService)
        {
            var model = new HomeViewModel
            {
                Cardapio = cardapioService.Obter()
            };

            return View(model);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
