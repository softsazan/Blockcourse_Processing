using System;
using System.Collections.Generic;

namespace Blockcourse_Processing.DataLayer.Entities;

public partial class YoutubeMedium
{
    public int YoutubeMediaId { get; set; }

    public int? YoutubeLessonsId { get; set; }

    public bool HaveText { get; set; }

    public string Title { get; set; } = null!;

    public DateTime CreateDate { get; set; }

    public string? Detail { get; set; }

    public string? MediaUrl { get; set; }

    public string? DownloadMediaUrl { get; set; }

    public string? MediaSize { get; set; }

    public string? MediaPicture { get; set; }

    public string? MediaDuration { get; set; }

    public int? ReportCount { get; set; }

    public string? DeepLink { get; set; }

    public bool IsPermium { get; set; }

    public bool IsShow { get; set; }

    public bool IsVideo { get; set; }

    public bool IsDelete { get; set; }

    public virtual ICollection<YouTubeMistakesReport> YouTubeMistakesReports { get; set; } = new List<YouTubeMistakesReport>();

    public virtual YoutubeLesson? YoutubeLessons { get; set; }

    public virtual YoutubeMediaText? YoutubeMediaText { get; set; }
}
