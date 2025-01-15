using System;
using System.Collections.Generic;

namespace DataService.Models;

public partial class Omsstockcreateapprovallog
{
    public int Id { get; set; }

    public int? Orderhistoryid { get; set; }

    public string? Stockstatus { get; set; }

    public int? Approverid { get; set; }

    public DateTime? Approvertimestamp { get; set; }

    public bool? Isactive { get; set; }
}
