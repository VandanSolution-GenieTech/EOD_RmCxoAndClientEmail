using System;
using System.Collections.Generic;

namespace DataService.Models;

public partial class Omsfmapprovaldatarequesterdetail
{
    public int Id { get; set; }

    public int? Makerid { get; set; }

    public DateTime? Makertimestamp { get; set; }

    public int? Orderhistoryid { get; set; }

    public bool? Isactive { get; set; }
}
