using System;
using System.Collections.Generic;

namespace DataService.Models;

public partial class Omsstocklog
{
    public int Id { get; set; }

    public int? Invid { get; set; }

    public int? Tradeid { get; set; }

    public int? Status { get; set; }

    public int? Createdby { get; set; }

    public DateTime? Createdon { get; set; }

    public ulong? Isactive { get; set; }
}
