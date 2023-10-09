using System;
using System.Collections.Generic;

namespace Blockcourse_Processing.DataLayer.Entities;

public partial class TiktokLike
{
    public int TiktokLikeId { get; set; }

    public int UserId { get; set; }

    public int TiktokMediaId { get; set; }

    public DateTime CareteDate { get; set; }

    public bool IsUploadedOnServer { get; set; }

    public virtual TiktokMedium TiktokMedia { get; set; } = null!;

    public virtual User User { get; set; } = null!;
}
