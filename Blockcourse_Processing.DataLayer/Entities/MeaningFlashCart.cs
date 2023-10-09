using System;
using System.Collections.Generic;

namespace Blockcourse_Processing.DataLayer.Entities;

public partial class MeaningFlashCart
{
    public int MeaningFlashCartId { get; set; }

    public int FlashCartId { get; set; }

    public string? Meaning { get; set; }

    public bool IsDelete { get; set; }

    public virtual ICollection<ExampleWord> ExampleWords { get; set; } = new List<ExampleWord>();

    public virtual FlashCart FlashCart { get; set; } = null!;
}
