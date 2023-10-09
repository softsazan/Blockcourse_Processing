using System;
using System.Collections.Generic;

namespace Blockcourse_Processing.DataLayer.Entities;

public partial class ExampleWord
{
    public int ExampleWordId { get; set; }

    public int MeaningFlashCartId { get; set; }

    public string? Example { get; set; }

    public string? MeaningOfExample { get; set; }

    public virtual MeaningFlashCart MeaningFlashCart { get; set; } = null!;
}
