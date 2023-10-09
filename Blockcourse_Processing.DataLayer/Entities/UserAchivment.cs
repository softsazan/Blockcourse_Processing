using System;
using System.Collections.Generic;

namespace Blockcourse_Processing.DataLayer.Entities;

public partial class UserAchivment
{
    public int UserAchivmentId { get; set; }

    public int UserAchivmentCategoryId { get; set; }

    public int UserAchivmentTypeId { get; set; }

    public string Title { get; set; } = null!;

    public string? Detail { get; set; }

    public int Amount { get; set; }

    public string Picture { get; set; } = null!;

    public bool IsDelete { get; set; }

    public virtual ICollection<UserAchivment1> UserAchivment1s { get; set; } = new List<UserAchivment1>();

    public virtual UserAchivmentCategory UserAchivmentCategory { get; set; } = null!;

    public virtual UserAchivmentType UserAchivmentType { get; set; } = null!;
}
