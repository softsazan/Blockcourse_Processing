using System;
using System.Collections.Generic;

namespace Blockcourse_Processing.DataLayer.Entities;

public partial class YouTubeMistakesReport
{
    public int TiktokMistakesReportId { get; set; }

    public int YoutubeMediaId { get; set; }

    public int UserId { get; set; }

    public int? SentenceNumber { get; set; }

    public string ReportText { get; set; } = null!;

    public bool IsAdminConfirmed { get; set; }

    public virtual User User { get; set; } = null!;

    public virtual YoutubeMedium YoutubeMedia { get; set; } = null!;
}
