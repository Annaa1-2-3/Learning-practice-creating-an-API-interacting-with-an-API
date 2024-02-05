using System;
using System.Collections.Generic;

namespace Data_Access.Models;

public partial class User
{
    public int UserId { get; set; }

    public string Name { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Password { get; set; } = null!;

    public DateTime RegistrationDate { get; set; }

    public bool UserDeleted { get; set; }

    public virtual ICollection<Action> Actions { get; set; } = new List<Action>();
}
