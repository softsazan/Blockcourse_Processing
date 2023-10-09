global using Microsoft.AspNetCore.Mvc;
using Blockcourse_Processing.Core.Servies.InterFace;

namespace Blockcourse_Processing.Controllers
{
    public class SpotifyController : Controller
    {
        private readonly ISpotifyServies _spotifyServies;
        public SpotifyController(ISpotifyServies spotifyServies)
        {
                _spotifyServies = spotifyServies;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
