using System;
using System.Collections.Generic;

namespace Blockcourse_Processing.DataLayer.Entities;

public partial class Grammer
{
    public int GrammerId { get; set; }

    public int GrammerCategoryId { get; set; }

    public string Title { get; set; } = null!;

    public string Detail { get; set; } = null!;

    public int RoadMapSort { get; set; }

    public bool IsDelete { get; set; }

    public virtual GrammerCategory GrammerCategory { get; set; } = null!;

    public virtual ICollection<GrammerLesson> GrammerLessons { get; set; } = new List<GrammerLesson>();
}
