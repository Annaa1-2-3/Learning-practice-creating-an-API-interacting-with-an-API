using System;
using System.Collections.Generic;

namespace Data_Access.Models;

public partial class Record
{
    public int RecordId { get; set; }

    public int UserId { get; set; }

    public string Title { get; set; } = null!;

    public string Description { get; set; } = null!;

    public int CategoryId { get; set; }

    public DateTime CreationDate { get; set; }

    public DateTime? DeletionDate { get; set; }

    public bool RecordsDeleted { get; set; }

    public int? UserDeleted { get; set; }

    public virtual ICollection<Action> Actions { get; set; } = new List<Action>();
}
