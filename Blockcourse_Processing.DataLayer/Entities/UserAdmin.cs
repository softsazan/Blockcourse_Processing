using System;
using System.Collections.Generic;

namespace Blockcourse_Processing.DataLayer.Entities;

public partial class UserAdmin
{
    public int UserAdminId { get; set; }

    public int UserId { get; set; }

    public string NameAdmin { get; set; } = null!;

    public DateTime Register { get; set; }

    public virtual ICollection<ReadyTicket> ReadyTickets { get; set; } = new List<ReadyTicket>();

    public virtual ICollection<SpotifyMedium> SpotifyMedia { get; set; } = new List<SpotifyMedium>();

    public virtual ICollection<TiktokMedium> TiktokMedia { get; set; } = new List<TiktokMedium>();

    public virtual User User { get; set; } = null!;

    public virtual ICollection<UserTicket> UserTickets { get; set; } = new List<UserTicket>();

    public virtual ICollection<YoutubeLesson> YoutubeLessons { get; set; } = new List<YoutubeLesson>();
}
