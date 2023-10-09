using System;
using System.Collections.Generic;

namespace Blockcourse_Processing.DataLayer.Entities;

public partial class WalletType
{
    public int TypeId { get; set; }

    public string TypeTitle { get; set; } = null!;

    public virtual ICollection<Wallet> Wallets { get; set; } = new List<Wallet>();
}
