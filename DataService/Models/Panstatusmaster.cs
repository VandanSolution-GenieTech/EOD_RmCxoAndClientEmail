using System;
using System.Collections.Generic;

namespace DataService.Models;

public partial class Panstatusmaster
{
    public int Id { get; set; }

    public string? Statuscode { get; set; }

    public string? Statusdescription { get; set; }

    public bool? Isactive { get; set; }
}
