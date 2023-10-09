using System;
using System.Collections.Generic;

namespace Blockcourse_Processing.DataLayer.Entities;

public partial class SpotifyMediaText
{
    public int SpotifyMediaTextId { get; set; }

    public int SpotifyMediaId { get; set; }

    public string PeText { get; set; } = null!;

    public string EnText { get; set; } = null!;

    public string? Level1NewText { get; set; }

    public int Level1NewWordCount { get; set; }

    public string? Level2NewText { get; set; }

    public int Level2NewWordCount { get; set; }

    public string? Level3NewText { get; set; }

    public int Level3NewWordCount { get; set; }

    public string? Level4NewText { get; set; }

    public int Level4NewWordCount { get; set; }

    public string? Level5NewText { get; set; }

    public int Level5NewWordCount { get; set; }

    public string? Level6NewText { get; set; }

    public int Level6NewWordCount { get; set; }

    public int? VisitCount { get; set; }

    public virtual SpotifyMedium SpotifyMedia { get; set; } = null!;
}
