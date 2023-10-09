using Blockcourse_Processing.Core.Servies.InterFace;

namespace Blockcourse_Processing.Controllers
{
    public class YoutubeController : Controller
    {
        private readonly IYouTubeServies _youTubeServies;   
        public YoutubeController(IYouTubeServies youTubeServies)
        {
            _youTubeServies=youTubeServies;    
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
