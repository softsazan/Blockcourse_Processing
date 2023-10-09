using System;
using System.Collections.Generic;

namespace Blockcourse_Processing.DataLayer.Entities;

public partial class SpotifyMistakesReport
{
    public int YouTubeMistakesReportId { get; set; }

    public int UserId { get; set; }

    public int SpotifyMediaId { get; set; }

    public int? SentenceNumber { get; set; }

    public string ReportText { get; set; } = null!;

    public bool IsAdminConfirmed { get; set; }

    public virtual SpotifyMedium SpotifyMedia { get; set; } = null!;

    public virtual User User { get; set; } = null!;
}
