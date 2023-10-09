using System;
using System.Collections.Generic;

namespace Blockcourse_Processing.DataLayer.Entities;

public partial class TiktokCategory
{
    public int TiktokCategoryId { get; set; }

    public string Title { get; set; } = null!;

    public string? Picture { get; set; }

    public bool IsShowOnMainPage { get; set; }

    public bool IsDelete { get; set; }

    public virtual ICollection<TiktokMedium> TiktokMedia { get; set; } = new List<TiktokMedium>();
}
