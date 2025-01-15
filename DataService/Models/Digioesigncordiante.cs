using System;
using System.Collections.Generic;

namespace DataService.Models;

public partial class Digioesigncordiante
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Cordinates { get; set; }

    public ulong? Isactive { get; set; }
}
