using System;
using System.Collections.Generic;

namespace Blockcourse_Processing.DataLayer.Entities;

public partial class UserLevel
{
    public int UserLevelId { get; set; }

    public string NickName { get; set; } = null!;

    public int LevelNumber { get; set; }

    public string? LevelTitle { get; set; }

    public string? LevelPictuer { get; set; }

    public string? Detail { get; set; }

    public int? GiftPrice { get; set; }

    public string? GiftTitle { get; set; }

    public virtual ICollection<User> Users { get; set; } = new List<User>();
}
