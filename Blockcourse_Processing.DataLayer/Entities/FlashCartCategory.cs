using System;
using System.Collections.Generic;

namespace Blockcourse_Processing.DataLayer.Entities;

public partial class FlashCartCategory
{
    public int FlashCartCategoryId { get; set; }

    public string Title { get; set; } = null!;

    public string? Detail { get; set; }

    public string? Picture { get; set; }

    public bool IsPermium { get; set; }

    public bool IsDelete { get; set; }

    public virtual ICollection<FlashCart> FlashCarts { get; set; } = new List<FlashCart>();
}
