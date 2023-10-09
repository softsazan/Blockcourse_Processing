using System;
using System.Collections.Generic;

namespace Blockcourse_Processing.DataLayer.Entities;

public partial class UserSub
{
    public int UserSubsId { get; set; }

    public int UserId { get; set; }

    public int SubsId { get; set; }

    public virtual Sub Subs { get; set; } = null!;

    public virtual User User { get; set; } = null!;
}
