using System;
using System.Collections.Generic;

namespace DataService.Models;

public partial class Omsbondinsertionlogdetail
{
    public int Id { get; set; }

    public int? Orderhistoryid { get; set; }

    public int? Createdby { get; set; }

    public DateTime? Createdon { get; set; }

    public string? Status { get; set; }
}
