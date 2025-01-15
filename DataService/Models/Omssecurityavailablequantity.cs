using System;
using System.Collections.Generic;

namespace DataService.Models;

public partial class Omssecurityavailablequantity
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public decimal? Availablequantity { get; set; }

    public decimal? Notionalquantity { get; set; }

    public int? Createdby { get; set; }

    public DateTime? Createdon { get; set; }

    public bool? Isactive { get; set; }
}
