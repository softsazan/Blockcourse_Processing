using System;
using System.Collections.Generic;

namespace Blockcourse_Processing.DataLayer.Entities;

public partial class TikTokArtist
{
    public int TikTokArtistId { get; set; }

    public string ArtistName { get; set; } = null!;

    public string? ArtistPicture { get; set; }

    public bool IsDelete { get; set; }

    public virtual ICollection<TiktokMedium> TiktokMedia { get; set; } = new List<TiktokMedium>();
}
