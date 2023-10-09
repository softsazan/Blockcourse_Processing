using System;
using System.Collections.Generic;

namespace Blockcourse_Processing.DataLayer.Entities;

public partial class UserAward
{
    public int UserAwardsId { get; set; }

    public int UserId { get; set; }

    public int SlotMachineAwardsId { get; set; }

    public DateTime CreateDate { get; set; }

    public virtual SlotMachine SlotMachineAwards { get; set; } = null!;

    public virtual User User { get; set; } = null!;
}
