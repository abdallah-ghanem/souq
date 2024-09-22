using Microsoft.AspNetCore.Mvc;
using souq.Models;
using System.Diagnostics;

namespace souq.Controllers
{
    public class HomeController : Controller
    {
       /* private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
       */
        public IActionResult Index()
        {
            SouqContext db = new SouqContext();
            var cats = db.CatIds.ToList();
            return View(cats);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Category()
        {
            SouqContext db= new SouqContext();
            var cats= db.CatIds.ToList();
            return View(cats);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}