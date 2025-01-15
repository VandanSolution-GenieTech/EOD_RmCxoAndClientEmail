using System;
using System.Collections.Generic;

namespace DataService.Models;

public partial class Krastatusmaster
{
    public int Id { get; set; }

    public int? Statuscode { get; set; }

    public string? Remark { get; set; }

    public bool? Isactive { get; set; }
}
