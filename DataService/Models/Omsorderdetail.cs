using System;
using System.Collections.Generic;

namespace DataService.Models;

public partial class Omsorderdetail
{
    public int Id { get; set; }

    public int? SecurityId { get; set; }

    public int? Quantity { get; set; }

    public string? Orderstatus { get; set; }

    public string? Ordertype { get; set; }

    public int? Createdby { get; set; }

    public DateTime? Createdon { get; set; }

    public bool? Isactive { get; set; }
}
