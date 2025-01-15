using System;
using System.Collections.Generic;

namespace DataService.Models;

public partial class Omspaymentcreationlogdetail
{
    public int Id { get; set; }

    public int? Orderhistoryid { get; set; }

    public string? Paymentstatus { get; set; }

    public int? Makerid { get; set; }

    public DateTime? Makertimestamp { get; set; }

    public bool? Isactive { get; set; }
}
