using System;
using System.Collections.Generic;

namespace Blockcourse_Processing.DataLayer.Entities;

public partial class Tag
{
    public int TagsId { get; set; }

    public string PeName { get; set; } = null!;

    public string EnName { get; set; } = null!;

    public bool IsDelete { get; set; }

    public virtual ICollection<SpotifyTag> SpotifyTags { get; set; } = new List<SpotifyTag>();

    public virtual ICollection<TikTokTag> TikTokTags { get; set; } = new List<TikTokTag>();

    public virtual ICollection<UserTag> UserTags { get; set; } = new List<UserTag>();

    public virtual ICollection<YouTubeTag> YouTubeTags { get; set; } = new List<YouTubeTag>();
}
