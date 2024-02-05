using System;
using System.Collections.Generic;

namespace Data_Access.Models;

public partial class Action
{
    public int Attribute1 { get; set; }

    public int Attribute2 { get; set; }

    public int ActionsId { get; set; }

    public string ActionType { get; set; } = null!;

    public DateTime ActionDate { get; set; }

    public virtual Record Attribute1Navigation { get; set; } = null!;

    public virtual User Attribute2Navigation { get; set; } = null!;
}
