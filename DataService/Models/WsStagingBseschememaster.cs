using System;
using System.Collections.Generic;

namespace DataService.Models;

public partial class WsStagingBseschememaster
{
    public string? SchemeName { get; set; }

    public double? RedemptionMinUnit { get; set; }

    public double? RedemptionMinMultiplierUnit { get; set; }

    public long? PurchaseAmountMultiplier { get; set; }

    public long? PurchaseMaxAmt { get; set; }

    public long? RedemptionMinAmount { get; set; }

    public string? RedemptionCutOff { get; set; }

    public long? RedemptionMaxQty { get; set; }

    public long? RedemptionMaxAmt { get; set; }

    public string? AmcschemeCode { get; set; }

    public string? RedemptionFlag { get; set; }

    public long? RedemptionAmtMultiplier { get; set; }

    public string? PurchaseFlag { get; set; }

    public long? AdditionalPurchaseMinAmount { get; set; }

    public string? PurchaseCutOff { get; set; }

    public string? IsinCode { get; set; }

    public string? Uniqueno { get; set; }

    public string? AmcName { get; set; }

    public string? RedemptionDemat { get; set; }

    public string? EndDate { get; set; }

    public string? PurchaseDemat { get; set; }

    public string? WssymbolCode { get; set; }

    public long? FreshPurchaseMinAmount { get; set; }

    public string? SchemeCode { get; set; }

    public string? Rtaschemecode { get; set; }

    public string? Setttype { get; set; }

    public string? Switchflag { get; set; }

    public string? Swpflag { get; set; }

    public string? Plan { get; set; }

    public int Id { get; set; }

    public DateTime? Timestamp { get; set; }

    public bool? Isactive { get; set; }
}
