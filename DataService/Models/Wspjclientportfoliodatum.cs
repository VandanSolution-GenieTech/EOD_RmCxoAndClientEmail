using System;
using System.Collections.Generic;

namespace DataService.Models;

public partial class Wspjclientportfoliodatum
{
    public string? AsOnDate { get; set; }

    public long? Code { get; set; }

    public string? Description { get; set; }

    public string? Astcls { get; set; }

    public string? AstclsName { get; set; }

    public string? Category { get; set; }

    public string? CategoryName { get; set; }

    public string? SymbolCode { get; set; }

    public string? SymbolName { get; set; }

    public string? MinTranDate { get; set; }

    public double? Units { get; set; }

    public double? MktVal { get; set; }

    public long? Nav { get; set; }

    public long? AccruedInt { get; set; }

    public double? Income { get; set; }

    public double? TotalCost { get; set; }

    public double? TotalGain { get; set; }

    public double? GainPerc { get; set; }

    public long? XirrYield { get; set; }

    public long? AssetsPerc { get; set; }

    public long? Level { get; set; }

    public string? ThirdPartyFlag { get; set; }

    public long? WtdAvgDay { get; set; }

    public string? FilterBy { get; set; }

    public string? FilterValue { get; set; }
}
