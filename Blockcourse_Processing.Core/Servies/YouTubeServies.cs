namespace Blockcourse_Processing.Core.Servies
{
    public class YouTubeServies: IYouTubeServies
    {
        private readonly TikTokDbContext _context;  
        public YouTubeServies(TikTokDbContext context)
        {
            _context = context;    
        }
    }
}
