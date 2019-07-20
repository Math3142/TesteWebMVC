using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplicationTest1.Models;

namespace WebApplicationTest1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Esta aplicação WEB se destina a contar um pouco sobre Matheus Macedo, o criador desta aplicação.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Para contactar Matheus utilize as informações a seguir:";

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
