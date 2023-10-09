using System;
using System.Collections.Generic;

namespace Blockcourse_Processing.DataLayer.Entities;

public partial class YouTubeTag
{
    public int YouTubeTagsId { get; set; }

    public int TagsId { get; set; }

    public int YoutubeLessonsId { get; set; }

    public virtual Tag Tags { get; set; } = null!;

    public virtual YoutubeLesson YoutubeLessons { get; set; } = null!;
}
