using System;
using System.Collections.Generic;

namespace Blockcourse_Processing.DataLayer.Entities;

public partial class TikTokTag
{
    public int TikTokTagsId { get; set; }

    public int TagsId { get; set; }

    public int TiktokMediaId { get; set; }

    public virtual Tag Tags { get; set; } = null!;

    public virtual TiktokMedium TiktokMedia { get; set; } = null!;
}
