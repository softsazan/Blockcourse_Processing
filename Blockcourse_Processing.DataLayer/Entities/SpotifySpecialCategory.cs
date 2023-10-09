using System;
using System.Collections.Generic;

namespace Blockcourse_Processing.DataLayer.Entities;

public partial class SpotifySpecialCategory
{
    public int SpotifySpecialCategoryId { get; set; }

    public string Title { get; set; } = null!;

    public string? PictureName { get; set; }

    public string? BackgroundColor { get; set; }

    public bool IsShowOnMainPage { get; set; }

    public bool IsDelete { get; set; }

    public virtual ICollection<SpotifyMedium> SpotifyMedia { get; set; } = new List<SpotifyMedium>();
}
