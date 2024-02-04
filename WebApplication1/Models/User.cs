using System;
using System.Collections.Generic;

namespace WebApplication1.Models;

public partial class User
{
    public int UserId { get; set; }

    public string Username { get; set; } = null!;

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? Email { get; set; }

    public override String ToString()
    {
        return $"{Username} : {FirstName} : {LastName}\n";
    }
}
