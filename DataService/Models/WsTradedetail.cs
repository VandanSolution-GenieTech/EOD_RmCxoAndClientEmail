using System;
using System.Collections.Generic;

namespace DataService.Models;

public partial class WsTradedetail
{
    public int Id { get; set; }

    public string? Exchange { get; set; }

    public string? AccountCode { get; set; }

    public string? SubAccountCode { get; set; }

    public string? TrxDate { get; set; }

    public string? ExcSymbol { get; set; }

    public string? ExpiryDate { get; set; }

    public string? ProductCode { get; set; }

    public decimal? StrikePrice { get; set; }

    public string? OptionType { get; set; }

    public string? IsinCode { get; set; }

    public string? BuySell { get; set; }

    public string? ScripName { get; set; }

    public decimal? Quantity { get; set; }

    public decimal? QuantityLot { get; set; }

    public decimal? TradeAmt { get; set; }

    public decimal? MktAmt { get; set; }

    public decimal? GBrokAmt { get; set; }

    public decimal? BrokAmt { get; set; }

    public decimal? Stt { get; set; }

    public decimal? OtherCharges { get; set; }

    public decimal? ServiceTax { get; set; }

    public string? TradeType { get; set; }

    public string? SettCode { get; set; }

    public string? ContNo { get; set; }

    public bool? Isactive { get; set; }

    public DateTime? CreatedOn { get; set; }
}
