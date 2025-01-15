using System;
using System.Collections.Generic;

namespace DataService.Models;

public partial class WsPortfolioholdingdatum
{
    public double? Quantity { get; set; }

    public double? Marketvalue { get; set; }

    public string? Symbolcode { get; set; }

    public double? Unitcost { get; set; }

    public string? Astcls { get; set; }

    public string? Isincode { get; set; }

    public long? Accruedinterest { get; set; }

    public double? GainLoss { get; set; }

    public string? Name { get; set; }

    public string? Symbolname { get; set; }

    public long? Code { get; set; }

    public double? Marketrate { get; set; }

    public string? Asondate { get; set; }

    public double? GainLossPercentage { get; set; }

    public string? Positionflag { get; set; }

    public int Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public bool? Isactive { get; set; }
}
