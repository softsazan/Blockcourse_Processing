using Blockcourse_Processing.Core.Servies.InterFace;
using Blockcourse_Processing.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Blockcourse_Processing.Controllers
{
    public class HomeController : Controller
    {
        private readonly ITikTokServies _tikTokServies;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger,ITikTokServies tikTokServies)
        {
            _logger = logger;
            _tikTokServies = tikTokServies;
        }

        public IActionResult Index()
        {
            _tikTokServies.add();
            _tikTokServies.UpdateUrlToHls();    
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