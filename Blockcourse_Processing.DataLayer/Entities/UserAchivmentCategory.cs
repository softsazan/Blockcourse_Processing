using System;
using System.Collections.Generic;

namespace Blockcourse_Processing.DataLayer.Entities;

public partial class UserAchivmentCategory
{
    public int UserAchivmentCategoryId { get; set; }

    public string Title { get; set; } = null!;

    public string Detail { get; set; } = null!;

    public bool IsDelete { get; set; }

    public virtual ICollection<UserAchivment> UserAchivments { get; set; } = new List<UserAchivment>();
}
