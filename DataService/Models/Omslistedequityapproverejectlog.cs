using System;
using System.Collections.Generic;

namespace DataService.Models;

public partial class Omslistedequityapproverejectlog
{
    public int Id { get; set; }

    public int? Invid { get; set; }

    public int? Tradeid { get; set; }

    public string? Status { get; set; }

    public string? Remark { get; set; }

    public string? Reason { get; set; }

    public int? Createdby { get; set; }

    public DateTime? Createdon { get; set; }

    public bool? Isactive { get; set; }
}
