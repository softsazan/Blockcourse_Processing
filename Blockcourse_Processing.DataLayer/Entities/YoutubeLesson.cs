using System;
using System.Collections.Generic;

namespace Blockcourse_Processing.DataLayer.Entities;

public partial class YoutubeLesson
{
    public int YoutubeLessonsId { get; set; }

    public int YouTubeCategoryId { get; set; }

    public int UserEnglishLevelId { get; set; }

    public int UserAdminId { get; set; }

    public int YouTubeArtistId { get; set; }

    public int? YouTubePosterId { get; set; }

    public int? YouTubeSpecialCategoryId { get; set; }

    public string Title { get; set; } = null!;

    public string? Detail { get; set; }

    public string? TotalSize { get; set; }

    public string? Picture { get; set; }

    public string? TotalDuration { get; set; }

    public int? LikeCount { get; set; }

    public bool IsReady { get; set; }

    public bool IsVideo { get; set; }

    public bool HaveText { get; set; }

    public DateTime CreatedDate { get; set; }

    public bool IsDelete { get; set; }

    public int Level1NewWordCount { get; set; }

    public int Level2NewWordCount { get; set; }

    public int Level3NewWordCount { get; set; }

    public int Level4NewWordCount { get; set; }

    public int Level5NewWordCount { get; set; }

    public int Level6NewWordCount { get; set; }

    public virtual UserAdmin UserAdmin { get; set; } = null!;

    public virtual UserEnglishLevel UserEnglishLevel { get; set; } = null!;

    public virtual YouTubeArtist YouTubeArtist { get; set; } = null!;

    public virtual YouTubeCategory YouTubeCategory { get; set; } = null!;

    public virtual YouTubePoster? YouTubePoster { get; set; }

    public virtual YouTubeSpecialCategory? YouTubeSpecialCategory { get; set; }

    public virtual ICollection<YouTubeTag> YouTubeTags { get; set; } = new List<YouTubeTag>();

    public virtual ICollection<YoutubeMedium> YoutubeMedia { get; set; } = new List<YoutubeMedium>();
}
