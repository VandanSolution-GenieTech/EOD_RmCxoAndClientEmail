using System;
using System.Collections.Generic;

namespace DataService.Models;

public partial class Omsbsetradeorder
{
    public int Id { get; set; }

    public string? Reportedsystem { get; set; }

    public string? Dealid { get; set; }

    public DateTime? Tradedate { get; set; }

    public DateTime? Settdate { get; set; }

    public string? Setttype { get; set; }

    public string? Settno { get; set; }

    public string? Settstatus { get; set; }

    public string? Buyer { get; set; }

    public string? Seller { get; set; }

    public string? Buycustodian { get; set; }

    public string? Sellcustodian { get; set; }

    public string? Symbol { get; set; }

    public string? Isin { get; set; }

    public decimal? Qty { get; set; }

    public decimal? Price { get; set; }

    public decimal? Tradevalue { get; set; }

    public decimal? Accruedint { get; set; }

    public decimal? Consideration { get; set; }

    public decimal? Stampdutyvalue { get; set; }

    public decimal? Totalconsideration { get; set; }

    public string? Buyerconfirmation { get; set; }

    public string? Sellerconfirmation { get; set; }

    public string? Buycustodianconfirmation { get; set; }

    public string? Sellcustodianconfirmation { get; set; }

    public string? Payinsecurity { get; set; }

    public string? Payinfund { get; set; }

    public string? Payoutsecurity { get; set; }

    public string? Payoutfundutrno { get; set; }

    public DateTime? Ondate { get; set; }

    public bool? Isactive { get; set; }

    public bool? Ismatching { get; set; }

    public int? Uploadedby { get; set; }

    public DateTime? Createdon { get; set; }
}
