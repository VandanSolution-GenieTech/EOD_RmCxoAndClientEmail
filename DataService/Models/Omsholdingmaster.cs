using System;
using System.Collections.Generic;

namespace DataService.Models;

public partial class Omsholdingmaster
{
    public int Id { get; set; }

    public int? Entityid { get; set; }

    public int? Scriptid { get; set; }

    public decimal? Freequantity { get; set; }

    public decimal? Holdquantity { get; set; }

    public decimal? Pledgequantity { get; set; }

    public decimal? Netquantity { get; set; }

    public decimal? Price { get; set; }

    public decimal? Value { get; set; }

    public decimal? Minimumsellprice { get; set; }

    public decimal? Rangevalue { get; set; }

    public bool? Isactive { get; set; }

    public decimal? Notionalquatity { get; set; }
}
