using System;
using System.Collections.Generic;

namespace DataService.Models;

public partial class Wsqueryfile
{
    public int Srno { get; set; }

    public string? Queryname { get; set; }

    public string? Queryfile { get; set; }

    public bool? Isactive { get; set; }
}
