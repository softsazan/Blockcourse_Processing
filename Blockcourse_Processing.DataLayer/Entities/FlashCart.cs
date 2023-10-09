using System;
using System.Collections.Generic;

namespace Blockcourse_Processing.DataLayer.Entities;

public partial class FlashCart
{
    public int FlashCartId { get; set; }

    public int FlashCartCategoryId { get; set; }

    public string Word { get; set; } = null!;

    public bool IsDelete { get; set; }

    public virtual FlashCartCategory FlashCartCategory { get; set; } = null!;

    public virtual ICollection<MeaningFlashCart> MeaningFlashCarts { get; set; } = new List<MeaningFlashCart>();
}
