using System;
using System.Collections.Generic;

namespace Blockcourse_Processing.DataLayer.Entities;

public partial class SubType
{
    public int SubTypeId { get; set; }

    public int SubDurtion { get; set; }

    public string Title { get; set; } = null!;

    public string? Detail { get; set; }

    public int Price { get; set; }

    public int PriceDiscounted { get; set; }

    public string CallbackUri { get; set; } = null!;

    public string OrderId { get; set; } = null!;

    public string SkuName { get; set; } = null!;

    public string CafebazarSku { get; set; } = null!;

    public string GoogleplaySku { get; set; } = null!;

    public string Deeplink { get; set; } = null!;

    public bool IsDelete { get; set; }

    public virtual ICollection<Sub> Subs { get; set; } = new List<Sub>();
}
