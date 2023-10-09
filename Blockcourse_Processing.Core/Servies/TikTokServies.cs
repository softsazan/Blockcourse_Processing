global using Blockcourse_Processing.Core.Servies.InterFace;
global using Blockcourse_Processing.DataLayer.Context;


namespace Blockcourse_Processing.Core.Servies
{
    public class TikTokServies: ITikTokServies
    {
        private readonly TikTokDbContext _context;
        public TikTokServies(TikTokDbContext context)
        {
            _context = context;
        }


    }
}
