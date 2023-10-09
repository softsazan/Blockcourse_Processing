using System;
using System.Collections.Generic;

namespace Blockcourse_Processing.DataLayer.Entities;

public partial class User
{
    public int UserId { get; set; }

    public int? UserLevelId { get; set; }

    public int? UserEnglishLevelId { get; set; }

    public string? UserName { get; set; }

    public string? Password { get; set; }

    public string? Name { get; set; }

    public string? SurName { get; set; }

    public string? Email { get; set; }

    public string? ProfilePicture { get; set; }

    public int? WordCount { get; set; }

    public DateTime BirthDate { get; set; }

    public string PhoneNumber { get; set; } = null!;

    public bool PhoneNumberConfirmed { get; set; }

    public string? LightnerWords { get; set; }

    public string? HighLightWord { get; set; }

    public int? SlotMachineChanceCount { get; set; }

    public bool IsAccountVerifyed { get; set; }

    public DateTime RegisterDate { get; set; }

    public string VerificationCode { get; set; } = null!;

    public int AccessFailedCount { get; set; }

    public DateTime LastVerificationCodeRequestTime { get; set; }

    public bool IsLocked { get; set; }

    public string? Bio { get; set; }

    public bool Gender { get; set; }

    public string? UserNameInstagram { get; set; }

    public int? DailyPurposeOfUsing { get; set; }

    public virtual ICollection<SpotifyMistakesReport> SpotifyMistakesReports { get; set; } = new List<SpotifyMistakesReport>();

    public virtual ICollection<TikTokComment> TikTokComments { get; set; } = new List<TikTokComment>();

    public virtual ICollection<TiktokLike> TiktokLikes { get; set; } = new List<TiktokLike>();

    public virtual ICollection<TiktokMistakesReport> TiktokMistakesReports { get; set; } = new List<TiktokMistakesReport>();

    public virtual ICollection<UserAchivment1> UserAchivment1s { get; set; } = new List<UserAchivment1>();

    public virtual ICollection<UserAdmin> UserAdmins { get; set; } = new List<UserAdmin>();

    public virtual ICollection<UserAward> UserAwards { get; set; } = new List<UserAward>();

    public virtual UserEnglishLevel? UserEnglishLevel { get; set; }

    public virtual UserLevel? UserLevel { get; set; }

    public virtual ICollection<UserRole> UserRoles { get; set; } = new List<UserRole>();

    public virtual ICollection<UserSub> UserSubs { get; set; } = new List<UserSub>();

    public virtual ICollection<UserTag> UserTags { get; set; } = new List<UserTag>();

    public virtual ICollection<UserTicket> UserTickets { get; set; } = new List<UserTicket>();

    public virtual ICollection<UsersActivity> UsersActivities { get; set; } = new List<UsersActivity>();

    public virtual ICollection<Wallet> Wallets { get; set; } = new List<Wallet>();

    public virtual ICollection<YouTubeMistakesReport> YouTubeMistakesReports { get; set; } = new List<YouTubeMistakesReport>();
}
