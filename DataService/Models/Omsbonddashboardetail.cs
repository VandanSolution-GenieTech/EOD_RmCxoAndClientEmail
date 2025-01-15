using System;
using System.Collections.Generic;

namespace DataService.Models;

public partial class Omsbonddashboardetail
{
    public int Id { get; set; }

    public int? Orderhistoryid { get; set; }

    public int? Approverid { get; set; }

    public DateTime? Approvertimestamp { get; set; }

    public decimal? Yeild { get; set; }

    public decimal? Facevalue { get; set; }

    public decimal? Interestrate { get; set; }

    public decimal? Tcwithoutstampduty { get; set; }

    public decimal? Tcwithstampduty { get; set; }

    public decimal? Stampduty { get; set; }

    public string? Settlment { get; set; }

    public DateTime? Tradedate { get; set; }

    public DateTime? Tradetime { get; set; }

    public string? Sendfor { get; set; }

    public string? Platform { get; set; }

    public string? Status { get; set; }

    public string? Remark { get; set; }

    public DateTime? Issuancedate { get; set; }

    public DateTime? Maturitydate { get; set; }

    public decimal? Maturityamount { get; set; }

    public DateTime? Dealdate { get; set; }

    public DateTime? Valuedate { get; set; }

    public DateTime? Calldate { get; set; }

    public decimal? Accruedinterest { get; set; }

    public decimal? Maturityprice { get; set; }

    public decimal? Maturityvalue { get; set; }

    public string? Seller { get; set; }

    public string? Buyer { get; set; }

    public decimal? Actualpriceordered { get; set; }

    public bool? Isactive { get; set; }

    public int? Noofdays { get; set; }
}
