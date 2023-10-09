using System;
using System.Collections.Generic;

namespace Blockcourse_Processing.DataLayer.Entities;

public partial class UserAchivment1
{
    public int UserAchivmentsId { get; set; }

    public int UserAchivmentId { get; set; }

    public int UserId { get; set; }

    public virtual User User { get; set; } = null!;

    public virtual UserAchivment UserAchivment { get; set; } = null!;
}
