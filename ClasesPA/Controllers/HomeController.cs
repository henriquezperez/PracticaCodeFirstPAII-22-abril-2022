using ClasesPA.Models;
using ClasesPA.Services;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ClasesPA.Controllers
{
    public class HomeController : Controller
    {
        private IEnrrollements _enrrollements;
         
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}