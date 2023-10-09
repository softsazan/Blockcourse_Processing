using System;
using System.Collections.Generic;

namespace Blockcourse_Processing.DataLayer.Entities;

public partial class GrammerLesson
{
    public int GrammerLessonsId { get; set; }

    public int GrammerId { get; set; }

    public int GrammerObjectTypeId { get; set; }

    public int Sort { get; set; }

    public string? EnText { get; set; }

    public string? PeText { get; set; }

    public string? Title { get; set; }

    public string? Text { get; set; }

    public string? BgColor { get; set; }

    public string? Table { get; set; }

    public string? VideoLink { get; set; }

    public bool IsPermium { get; set; }

    public virtual Grammer Grammer { get; set; } = null!;

    public virtual GrammerObjectType GrammerObjectType { get; set; } = null!;
}
