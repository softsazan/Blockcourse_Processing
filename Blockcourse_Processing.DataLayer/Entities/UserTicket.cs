using System;
using System.Collections.Generic;

namespace Blockcourse_Processing.DataLayer.Entities;

public partial class UserTicket
{
    public int UserTicketId { get; set; }

    public int UserAdminId { get; set; }

    public int UserId { get; set; }

    public string? PictureLink { get; set; }

    public string? VideoLink { get; set; }

    public string? Title { get; set; }

    public string? Detail { get; set; }

    public DateTime? SendDate { get; set; }

    public bool IsRead { get; set; }

    public virtual User User { get; set; } = null!;

    public virtual UserAdmin UserAdmin { get; set; } = null!;
}
