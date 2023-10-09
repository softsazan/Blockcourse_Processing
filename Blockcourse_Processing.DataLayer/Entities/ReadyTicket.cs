using System;
using System.Collections.Generic;

namespace Blockcourse_Processing.DataLayer.Entities;

public partial class ReadyTicket
{
    public int ReadyTicketId { get; set; }

    public int UserAdminId { get; set; }

    public string? PictureLink { get; set; }

    public string? VideoLink { get; set; }

    public string Title { get; set; } = null!;

    public string? Detail { get; set; }

    public int? SendAfterDays { get; set; }

    public virtual UserAdmin UserAdmin { get; set; } = null!;
}
