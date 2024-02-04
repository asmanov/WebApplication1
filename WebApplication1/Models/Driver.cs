using System;
using System.Collections.Generic;

namespace WebApplication1.Models;

public partial class Driver
{
    public int? DriverId { get; set; }

    public string? LastName { get; set; }

    public string? FirstName { get; set; }

    public string? OriginCity { get; set; }
}
