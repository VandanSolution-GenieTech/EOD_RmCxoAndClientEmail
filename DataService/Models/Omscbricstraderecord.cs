using System;
using System.Collections.Generic;

namespace DataService.Models;

public partial class Omscbricstraderecord
{
    public int Id { get; set; }

    public string? Transactionno { get; set; }

    public string? Isin { get; set; }

    public string? Issuetype { get; set; }

    public DateTime? Tradedate { get; set; }

    public DateTime? Reportedtiming { get; set; }

    public DateTime? Settledate { get; set; }

    public string? Seller { get; set; }

    public string? Buyer { get; set; }

    public string? Sellbroker { get; set; }

    public string? Buybroker { get; set; }

    public string? Descriptor { get; set; }

    public string? Status { get; set; }

    public string? Intention { get; set; }

    public int? Quantity { get; set; }

    public decimal? Price { get; set; }

    public decimal? Value { get; set; }

    public decimal? Accruedinterest { get; set; }

    public decimal? Consideration { get; set; }

    public string? Buycustodian { get; set; }

    public string? Sellcustodian { get; set; }

    public string? Sellerdealtype { get; set; }

    public string? Buyerdealtype { get; set; }

    public string? Buyerremarks { get; set; }

    public string? Sellerremarks { get; set; }

    public DateTime? Ondate { get; set; }

    public bool? Isactive { get; set; }

    public bool? Ismatching { get; set; }

    public int? Uploadedby { get; set; }

    public DateTime? Createdon { get; set; }
}
