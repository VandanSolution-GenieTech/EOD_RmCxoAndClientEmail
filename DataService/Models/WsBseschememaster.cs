using System;
using System.Collections.Generic;

namespace DataService.Models;

public partial class WsBseschememaster
{
    public string? Schemename { get; set; }

    public string? Startdate { get; set; }

    public double? MinRedemptionQty { get; set; }

    public double? RedemptionQtyMultiplier { get; set; }

    public long? PurAmountMultiplier { get; set; }

    public string? Uniqueno { get; set; }

    public long? MaxPurchaseAmount { get; set; }

    public long? LockinPeriod { get; set; }

    public long? RedemptionAmtMin { get; set; }

    public string? Redemptioncutofftime { get; set; }

    public string? Rtaschemecode { get; set; }

    public long? MaxRedemptionQty { get; set; }

    public long? RedemptionAmtMax { get; set; }

    public string? Amcschemecode { get; set; }

    public string? Redemptionallowed { get; set; }

    public long? RedemptionAmtMultiple { get; set; }

    public string? Purchaseallowed { get; set; }

    public string? Sipflag { get; set; }

    public string? SettlementType { get; set; }

    public long? AddPurchaseAmount { get; set; }

    public long? Amcactiveflag { get; set; }

    public string? Switchflag { get; set; }

    public string? Purchasecutofftime { get; set; }

    public string? Rtaagentcode { get; set; }

    public string? AmcInd { get; set; }

    public string? Exitloadflag { get; set; }

    public string? ChannelPartCode { get; set; }

    public string? LockinPeriodFlag { get; set; }

    public long? Facevalue { get; set; }

    public string? Schemetype { get; set; }

    public string? Isin { get; set; }

    public string? Amccode { get; set; }

    public string? Exitload { get; set; }

    public string? RedemptionTransMode { get; set; }

    public string? Enddate { get; set; }

    public string? PurchaseTranMode { get; set; }

    public string? Wssymbolcode { get; set; }

    public long? MinPurchaseAmount { get; set; }

    public string? Swpflag { get; set; }

    public string? Schemeplan { get; set; }

    public string? Schemecode { get; set; }

    public string? DivReinvestmentFlag { get; set; }

    public string? Stpflag { get; set; }

    public DateTime? CreatedOn { get; set; }

    public bool? Isactive { get; set; }
}
