using System;
using System.Collections.Generic;

namespace Blockcourse_Processing.DataLayer.Entities;

public partial class UsersActivity
{
    public int UsersActivitiesId { get; set; }

    public int UserId { get; set; }

    public int? SpotifyWatchTime { get; set; }

    public int? YoutubeWatchTime { get; set; }

    public int? TikTokWatchTime { get; set; }

    public bool ReachedGoal { get; set; }

    public int? DaysOfActivityChain { get; set; }

    public int? WeeklyTiktokWatchTime { get; set; }

    public int? MonthlyTiktokWatchTime { get; set; }

    public int? YearlyTiktokWatchTime { get; set; }

    public int? WeeklyYoutubeWatchTime { get; set; }

    public int? MonthlyYoutubeWatchTime { get; set; }

    public int? YearlyYoutubeWatchTime { get; set; }

    public int? WeeklySpotifyWatchTime { get; set; }

    public int? MonthlySpotifyWatchTime { get; set; }

    public int? YearlySpotifyWatchTime { get; set; }

    public int? WeeklyTotalWatchTime { get; set; }

    public int? MonthlyTotalWatchTime { get; set; }

    public int? YearlyTotalWatchTime { get; set; }

    public DateTime Date { get; set; }

    public virtual User User { get; set; } = null!;
}
