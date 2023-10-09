using System;
using System.Collections.Generic;

namespace Blockcourse_Processing.DataLayer.Entities;

public partial class UserTag
{
    public int UserTagsId { get; set; }

    public int UserId { get; set; }

    public int TagsId { get; set; }

    public virtual Tag Tags { get; set; } = null!;

    public virtual User User { get; set; } = null!;
}
