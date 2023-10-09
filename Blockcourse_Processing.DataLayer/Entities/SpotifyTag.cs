using System;
using System.Collections.Generic;

namespace Blockcourse_Processing.DataLayer.Entities;

public partial class SpotifyTag
{
    public int SpotifyTagsId { get; set; }

    public int TagsId { get; set; }

    public int SpotifyMediaId { get; set; }

    public virtual SpotifyMedium SpotifyMedia { get; set; } = null!;

    public virtual Tag Tags { get; set; } = null!;
}
