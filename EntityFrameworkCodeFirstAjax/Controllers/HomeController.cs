using EntityFrameworkCodeFirstAjax.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace EntityFrameworkCodeFirstAjax.Controllers
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
            using (NorthwindContext ctx = new NorthwindContext())
            {
                List<Category> Kategoriler = ctx.Categories.ToList();
            return View(Kategoriler);
            }
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
