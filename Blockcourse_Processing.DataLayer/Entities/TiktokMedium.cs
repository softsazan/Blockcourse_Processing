using System;
using System.Collections.Generic;

namespace Blockcourse_Processing.DataLayer.Entities;

public partial class TiktokMedium
{
    public int TiktokMediaId { get; set; }

    public int? TiktokSpecialCategoryId { get; set; }

    public int? TiktokPosterId { get; set; }

    public int UserAdminId { get; set; }

    public int UserEnglishLevelId { get; set; }

    public int TikTokArtistId { get; set; }

    public int TiktokCategoryId { get; set; }

    public bool HaveText { get; set; }

    public string Title { get; set; } = null!;

    public string Detail { get; set; } = null!;

    public string? MediaUrl { get; set; }

    public string? DownloadMediaUrl { get; set; }

    public string? MediaSize { get; set; }

    public string? MediaPicture { get; set; }

    public string? MediaDuration { get; set; }

    public int? LikeCount { get; set; }

    public int? ReportCount { get; set; }

    public string? DeepLink { get; set; }

    public bool IsShow { get; set; }

    public DateTime CreateDate { get; set; }

    public bool IsDelete { get; set; }

    public virtual TikTokArtist TikTokArtist { get; set; } = null!;

    public virtual ICollection<TikTokComment> TikTokComments { get; set; } = new List<TikTokComment>();

    public virtual ICollection<TikTokTag> TikTokTags { get; set; } = new List<TikTokTag>();

    public virtual TiktokCategory TiktokCategory { get; set; } = null!;

    public virtual ICollection<TiktokLike> TiktokLikes { get; set; } = new List<TiktokLike>();

    public virtual TiktokMediaText? TiktokMediaText { get; set; }

    public virtual ICollection<TiktokMistakesReport> TiktokMistakesReports { get; set; } = new List<TiktokMistakesReport>();

    public virtual TiktokPoster? TiktokPoster { get; set; }

    public virtual TiktokSpecialCategory? TiktokSpecialCategory { get; set; }

    public virtual UserAdmin UserAdmin { get; set; } = null!;

    public virtual UserEnglishLevel UserEnglishLevel { get; set; } = null!;
}
