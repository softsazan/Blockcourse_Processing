using System;
using System.Collections.Generic;

namespace Blockcourse_Processing.DataLayer.Entities;

public partial class SpotifyArtist
{
    public int SpotifyArtistId { get; set; }

    public string ArtistName { get; set; } = null!;

    public string? ArtistPicture { get; set; }

    public bool IsDelete { get; set; }

    public virtual ICollection<SpotifyMedium> SpotifyMedia { get; set; } = new List<SpotifyMedium>();
}
