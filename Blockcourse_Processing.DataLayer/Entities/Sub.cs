using System;
using System.Collections.Generic;

namespace Blockcourse_Processing.DataLayer.Entities;

public partial class Sub
{
    public int SubsId { get; set; }

    public int SubTypeId { get; set; }

    public DateTime BoughtDate { get; set; }

    public int PurchasedPrice { get; set; }

    public virtual SubType SubType { get; set; } = null!;

    public virtual ICollection<UserSub> UserSubs { get; set; } = new List<UserSub>();
}
