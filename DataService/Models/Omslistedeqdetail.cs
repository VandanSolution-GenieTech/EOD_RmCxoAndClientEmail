using System;
using System.Collections.Generic;

namespace DataService.Models;

public partial class Omslistedeqdetail
{
    public int Id { get; set; }

    public int Orderhistoryid { get; set; }

    public string? Buyselltype { get; set; }

    public int? Scripid { get; set; }

    public int? Quantitybooked { get; set; }

    public decimal? Actualpriceordered { get; set; }

    public decimal? Amount { get; set; }

    public decimal? Totalconsideration { get; set; }

    public int? Makerid { get; set; }

    public DateTime? Makertimestamp { get; set; }

    public int? Approverid { get; set; }

    public DateTime? Approvertimestamp { get; set; }

    public bool? Isactive { get; set; }

    public string? Reason { get; set; }

    public string? Remark { get; set; }
}
