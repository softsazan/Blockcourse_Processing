using System;
using System.Collections.Generic;

namespace Blockcourse_Processing.DataLayer.Entities;

public partial class GrammerObjectType
{
    public int GrammerObjectTypeId { get; set; }

    public string Type { get; set; } = null!;

    public bool IsDelete { get; set; }

    public virtual ICollection<GrammerLesson> GrammerLessons { get; set; } = new List<GrammerLesson>();
}
