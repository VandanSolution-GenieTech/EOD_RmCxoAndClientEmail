using System;
using System.Collections.Generic;

namespace DataService.Models;

public partial class Omsdocumentapproverejectdetail
{
    public int Id { get; set; }

    public int? Invid { get; set; }

    public int? Orderhistoryid { get; set; }

    public int? Approverid { get; set; }

    public DateTime? Approvertimestamp { get; set; }

    public string? Status { get; set; }

    public bool? Isactive { get; set; }
}
