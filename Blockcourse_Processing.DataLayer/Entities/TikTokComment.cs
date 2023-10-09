using System;
using System.Collections.Generic;

namespace Blockcourse_Processing.DataLayer.Entities;

public partial class TikTokComment
{
    public int TikTokCommentId { get; set; }

    public string Comment { get; set; } = null!;

    public int UserId { get; set; }

    public int? LikeCount { get; set; }

    public int TiktokMediaId { get; set; }

    public int? ReportCount { get; set; }

    public DateTime CreateDate { get; set; }

    public bool IsDelete { get; set; }

    public virtual TiktokMedium TiktokMedia { get; set; } = null!;

    public virtual User User { get; set; } = null!;
}
