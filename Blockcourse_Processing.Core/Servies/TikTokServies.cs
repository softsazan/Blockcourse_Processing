global using Blockcourse_Processing.Core.Servies.InterFace;
global using Blockcourse_Processing.DataLayer.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Text.Json;

namespace Blockcourse_Processing.Core.Servies
{
    public class TikTokServies : ITikTokServies
    {
        private readonly TikTokDbContext _context;
        private HttpClient _client;

        public TikTokServies(TikTokDbContext context)
        {
            _context = context;
            _client = new HttpClient();
        }

        public async Task UpdateUrlToHls()
        {
            var tiktolks = _context.TiktokMedia.ToList();
            var httpClient = new HttpClient();
            var request = new HttpRequestMessage(HttpMethod.Get, "https://napi.arvancloud.ir/vod/2.0/channels/82f37517-7b66-40f0-84ed-ed829107f403/videos?page=1");

            // اضافه کردن Authorization Header به درخواست
            request.Headers.Add("Authorization", "apikey aae80dad-dc9f-5eaf-a5d7-d91db62c8959");

            var response = await httpClient.SendAsync(request);
            if (response.IsSuccessStatusCode)
            {
                var responseContent = await response.Content.ReadAsStringAsync();
                var jsonResponse = JsonConvert.DeserializeObject<dynamic>(responseContent);

                var meta = jsonResponse.meta;
                int lastPage = meta.last_page;
              
                int currentPage = meta.current_page;
               
                List<dynamic> videos = jsonResponse.data.ToObject<List<dynamic>>();
                string hlsPlaylist = string.Empty;
                string videoUrl = string.Empty;


                foreach (var video in videos)
                {
                    var fileInfo = video.file_info;
                    var generalInfo = fileInfo.general;

                    double durationInSeconds = Convert.ToDouble(generalInfo.duration);
                    double sizeInBytes = Convert.ToDouble(generalInfo.size);

                    double durationInMinutes = durationInSeconds / 60;
                    double sizeInMegabytes = sizeInBytes / (1024 * 1024);
                    double roundedDurationInMinutes = Math.Ceiling(durationInMinutes);

                    hlsPlaylist = video.hls_playlist;
                    videoUrl = video.video_url;


                    //foreach (var tiktok in tiktolks)
                    //{
                    //    if (tiktok.MediaUrl== videoUrl)
                    //    {
                    //        tiktok.MediaUrl = hlsPlaylist;
                    //        tiktok.MediaDuration = roundedDurationInMinutes.ToString();
                    //        tiktok.MediaSize = sizeInBytes.ToString();
                    //        _context.TiktokMedia.Update(tiktok);
                    //        await _context.SaveChangesAsync();

                    //        Console.WriteLine($"ok : {tiktok.TiktokMediaId}");
                    //    }
                    //}

                   var t = tiktolks.Where(t => t.MediaUrl.Trim()==videoUrl.Trim()).SingleOrDefault();
                    if (t != null) {
                        t.MediaUrl = hlsPlaylist;
                        t.MediaDuration = roundedDurationInMinutes.ToString();
                        t.MediaSize = sizeInBytes.ToString();
                        _context.TiktokMedia.Update(t);
                        await _context.SaveChangesAsync();
                    }
                  

                }
            }
        }
          
        public async  Task<int> add()
        {

            var t =_context.TiktokMedia.Where(t => t.TiktokMediaId== 6).SingleOrDefault();
            return 1;
        }

    }
}
