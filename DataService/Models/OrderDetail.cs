using System;
using System.Collections.Generic;

namespace DataService.Models;

public partial class OrderDetail
{
    public string? ClientCode { get; set; }

    public string? ClientName { get; set; }

    public decimal? Amount { get; set; }

    public string? SchemeName { get; set; }

    public string? OrderNumber { get; set; }

    public string? OrderStatus { get; set; }

    public string? Date { get; set; }

    public string? FolioNo { get; set; }

    public decimal? Units { get; set; }

    public string? BuySell { get; set; }

    public string? BuySellType { get; set; }

    public string? OrderRemarks { get; set; }

    public string? Time { get; set; }

    public string? Euin { get; set; }

    public string? Kycflag { get; set; }

    public string? Dpc { get; set; }

    public string? SettNo { get; set; }

    public string? SettType { get; set; }

    public string? SchemeCode { get; set; }

    public string? EntryBy { get; set; }

    public string? FirstOrder { get; set; }

    public string? SipregnNo { get; set; }

    public string? SubOrderType { get; set; }

    public string? Dptrans { get; set; }

    public bool? Isactive { get; set; }
}
