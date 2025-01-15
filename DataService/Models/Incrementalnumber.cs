using System;
using System.Collections.Generic;

namespace DataService.Models;

public partial class Incrementalnumber
{
    public int Id { get; set; }

    public string Purpose { get; set; } = null!;

    public int NextNumber { get; set; }
}
