using System;
using System.Collections.Generic;

namespace Blockcourse_Processing.DataLayer.Entities;

public partial class GrammerCategory
{
    public int GrammerCategoryId { get; set; }

    public string Title { get; set; } = null!;

    public string Detail { get; set; } = null!;

    public bool IsDelete { get; set; }

    public virtual ICollection<Grammer> Grammers { get; set; } = new List<Grammer>();
}
