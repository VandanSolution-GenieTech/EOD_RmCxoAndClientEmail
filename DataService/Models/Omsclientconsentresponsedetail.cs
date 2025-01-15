using System;
using System.Collections.Generic;

namespace DataService.Models;

public partial class Omsclientconsentresponsedetail
{
    public int? Invid { get; set; }

    public int? Productid { get; set; }

    public string? Status { get; set; }

    public DateTime? Consenton { get; set; }

    public ulong? Isactive { get; set; }

    public int? Orderhistoryid { get; set; }

    public int Id { get; set; }

    public string? Clientcode { get; set; }
}
