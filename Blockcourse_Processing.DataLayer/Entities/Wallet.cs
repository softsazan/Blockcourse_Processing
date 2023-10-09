using System;
using System.Collections.Generic;

namespace Blockcourse_Processing.DataLayer.Entities;

public partial class Wallet
{
    public int WalletId { get; set; }

    public int TypeId { get; set; }

    public int UserId { get; set; }

    public int Amount { get; set; }

    public string Description { get; set; } = null!;

    public DateTime CreateDate { get; set; }

    public virtual WalletType Type { get; set; } = null!;

    public virtual User User { get; set; } = null!;
}
