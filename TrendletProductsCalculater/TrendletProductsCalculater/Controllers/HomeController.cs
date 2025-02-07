using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TrendletProductsCalculater.Models;

namespace TrendletProductsCalculater.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [Route("Bags")]
        public IActionResult Bags()
        {
            return View();
        }


        [Route("Clothes")]
        public IActionResult Clothes()
        {
            return View();
        }

        [Route("Shoes")]
        public IActionResult Shoes()
        {
            return View();
        }

        [Route("Accessories")]
        public IActionResult Accessories()
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
