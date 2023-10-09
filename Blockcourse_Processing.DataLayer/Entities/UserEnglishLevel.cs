using System;
using System.Collections.Generic;

namespace Blockcourse_Processing.DataLayer.Entities;

public partial class UserEnglishLevel
{
    public int UserEnglishLevelId { get; set; }

    public string Name { get; set; } = null!;

    public string? Detail { get; set; }

    public int StartPeriod { get; set; }

    public int EndPeriod { get; set; }

    public virtual ICollection<SpotifyMedium> SpotifyMedia { get; set; } = new List<SpotifyMedium>();

    public virtual ICollection<TiktokMedium> TiktokMedia { get; set; } = new List<TiktokMedium>();

    public virtual ICollection<User> Users { get; set; } = new List<User>();

    public virtual ICollection<YoutubeLesson> YoutubeLessons { get; set; } = new List<YoutubeLesson>();
}
