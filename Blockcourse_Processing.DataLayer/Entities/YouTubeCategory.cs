using System;
using System.Collections.Generic;

namespace Blockcourse_Processing.DataLayer.Entities;

public partial class YouTubeCategory
{
    public int YouTubeCategoryId { get; set; }

    public string Title { get; set; } = null!;

    public string? Picture { get; set; }

    public bool IsShowOnMainPage { get; set; }

    public bool IsDelete { get; set; }

    public virtual ICollection<YoutubeLesson> YoutubeLessons { get; set; } = new List<YoutubeLesson>();
}
