using System;
using System.Collections.Generic;

namespace Blockcourse_Processing.DataLayer.Entities;

public partial class SpotifyMedium
{
    public int SpotifyMediaId { get; set; }

    public int UserAdminId { get; set; }

    public int? SpotifySpecialCategoryId { get; set; }

    public int? SpotifyPosterId { get; set; }

    public int UserEnglishLevelId { get; set; }

    public int SpotifyArtistId { get; set; }

    public int SpotifyCategoryId { get; set; }

    public bool HaveText { get; set; }

    public string Title { get; set; } = null!;

    public DateTime CreateDate { get; set; }

    public string Detail { get; set; } = null!;

    public string? MediaUrl { get; set; }

    public string? DownloadMediaUrl { get; set; }

    public string? MediaSize { get; set; }

    public string? MediaPicture { get; set; }

    public string? MediaDuration { get; set; }

    public int? ReportCount { get; set; }

    public int? LikeCount { get; set; }

    public string? DeepLink { get; set; }

    public bool IsPermium { get; set; }

    public bool IsShow { get; set; }

    public bool IsDelete { get; set; }

    public virtual SpotifyArtist SpotifyArtist { get; set; } = null!;

    public virtual SpotifyCategory SpotifyCategory { get; set; } = null!;

    public virtual SpotifyMediaText? SpotifyMediaText { get; set; }

    public virtual ICollection<SpotifyMistakesReport> SpotifyMistakesReports { get; set; } = new List<SpotifyMistakesReport>();

    public virtual SpotifyPoster? SpotifyPoster { get; set; }

    public virtual SpotifySpecialCategory? SpotifySpecialCategory { get; set; }

    public virtual ICollection<SpotifyTag> SpotifyTags { get; set; } = new List<SpotifyTag>();

    public virtual UserAdmin UserAdmin { get; set; } = null!;

    public virtual UserEnglishLevel UserEnglishLevel { get; set; } = null!;
}
