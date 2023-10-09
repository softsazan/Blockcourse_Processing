
using Blockcourse_Processing.Core.Servies.InterFace;

namespace Blockcourse_Processing.Controllers
{
    public class TikTokController : Controller
    {
        private readonly ITikTokServies _tikTokServies;
        public TikTokController(ITikTokServies tikTokServies)
        {
            _tikTokServies = tikTokServies;   
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
