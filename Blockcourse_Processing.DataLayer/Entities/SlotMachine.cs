using System;
using System.Collections.Generic;

namespace Blockcourse_Processing.DataLayer.Entities;

public partial class SlotMachine
{
    public int SlotMachineAwardsId { get; set; }

    public string Title { get; set; } = null!;

    public string Detai { get; set; } = null!;

    public string BigImageUrl { get; set; } = null!;

    public string SmallImageUrl { get; set; } = null!;

    public decimal Probability { get; set; }

    public int? WinnersCount { get; set; }

    public bool IsActive { get; set; }

    public bool IsDelete { get; set; }

    public virtual ICollection<UserAward> UserAwards { get; set; } = new List<UserAward>();
}
