using System;
using System.Collections.Generic;

namespace Blockcourse_Processing.DataLayer.Entities;

public partial class Discount
{
    public int DiscountId { get; set; }

    public string DiscountCode { get; set; } = null!;

    public int Percent { get; set; }

    public int? UsableCount { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? EndDate { get; set; }
}
