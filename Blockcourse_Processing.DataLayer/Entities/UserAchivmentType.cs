using System;
using System.Collections.Generic;

namespace Blockcourse_Processing.DataLayer.Entities;

public partial class UserAchivmentType
{
    public int UserAchivmentTypeId { get; set; }

    public string Type { get; set; } = null!;

    public bool IsDelete { get; set; }

    public virtual ICollection<UserAchivment> UserAchivments { get; set; } = new List<UserAchivment>();
}
