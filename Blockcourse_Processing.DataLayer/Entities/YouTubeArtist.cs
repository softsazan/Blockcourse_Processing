using System;
using System.Collections.Generic;

namespace Blockcourse_Processing.DataLayer.Entities;

public partial class YouTubeArtist
{
    public int YouTubeArtistId { get; set; }

    public string ArtistName { get; set; } = null!;

    public string? ArtistPicture { get; set; }

    public bool IsDelete { get; set; }

    public virtual ICollection<YoutubeLesson> YoutubeLessons { get; set; } = new List<YoutubeLesson>();
}
