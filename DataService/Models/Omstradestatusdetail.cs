using System;
using System.Collections.Generic;

namespace DataService.Models;

public partial class Omstradestatusdetail
{
    public int Id { get; set; }

    public int? Approverid { get; set; }

    public int? Orderhistoryid { get; set; }

    public DateTime? Approvertimestamp { get; set; }

    public int? Status { get; set; }

    public string? Remark { get; set; }

    public string? Reason { get; set; }

    public bool? Isactive { get; set; }
}
