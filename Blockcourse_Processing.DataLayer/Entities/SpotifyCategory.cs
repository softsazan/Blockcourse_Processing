using System;
using System.Collections.Generic;

namespace Blockcourse_Processing.DataLayer.Entities;

public partial class SpotifyCategory
{
    public int SpotifyCategoryId { get; set; }

    public string Title { get; set; } = null!;

    public string? Picture { get; set; }

    public bool IsShowOnMainPage { get; set; }

    public bool IsDelete { get; set; }

    public virtual ICollection<SpotifyMedium> SpotifyMedia { get; set; } = new List<SpotifyMedium>();
}
