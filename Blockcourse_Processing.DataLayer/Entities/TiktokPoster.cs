﻿using System;
using System.Collections.Generic;

namespace Blockcourse_Processing.DataLayer.Entities;

public partial class TiktokPoster
{
    public int TiktokPosterId { get; set; }

    public string ImagePath { get; set; } = null!;

    public string RedirectLink { get; set; } = null!;

    public bool IsActive { get; set; }

    public bool IsSlide { get; set; }

    public bool IsDelete { get; set; }

    public virtual ICollection<TiktokMedium> TiktokMedia { get; set; } = new List<TiktokMedium>();
}
