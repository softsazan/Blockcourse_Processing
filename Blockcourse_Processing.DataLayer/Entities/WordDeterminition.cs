using System;
using System.Collections.Generic;

namespace Blockcourse_Processing.DataLayer.Entities;

public partial class WordDeterminition
{
    public int WordDeterminitionId { get; set; }

    public string Word { get; set; } = null!;

    public int Zrib { get; set; }

    public string? Level { get; set; }
}
