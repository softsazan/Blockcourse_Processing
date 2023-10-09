using System;
using System.Collections.Generic;

namespace Blockcourse_Processing.DataLayer.Entities;

public partial class TiktokMistakesReport
{
    public int TiktokMistakesReportId { get; set; }

    public int UserId { get; set; }

    public int TiktokMediaId { get; set; }

    public int? SentenceNumber { get; set; }

    public string ReportText { get; set; } = null!;

    public bool IsAdminConfirmed { get; set; }

    public virtual TiktokMedium TiktokMedia { get; set; } = null!;

    public virtual User User { get; set; } = null!;
}
