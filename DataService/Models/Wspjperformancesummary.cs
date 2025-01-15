using System;
using System.Collections.Generic;

namespace DataService.Models;

public partial class Wspjperformancesummary
{
    public long? ClientId { get; set; }

    public long? SchemeId { get; set; }

    public string? SchemeName { get; set; }

    public string? Mode { get; set; }

    public string? ModeStr { get; set; }

    public string? FromDate { get; set; }

    public string? ToDate { get; set; }

    public long? BeginMktVal { get; set; }

    public double? EndMktVal { get; set; }

    public double? Inflow { get; set; }

    public double? Outflow { get; set; }

    public double? Profit { get; set; }

    public double? Ror { get; set; }

    public double? RorAbs { get; set; }

    public double? Units { get; set; }

    public long? Nav { get; set; }

    public double? RealGain { get; set; }

    public double? UnrealGain { get; set; }

    public double? PriorGainLoss { get; set; }

    public double? Income { get; set; }

    public double? Expenses { get; set; }

    public double? AccInt { get; set; }

    public long? CommitAmt { get; set; }

    public long? Distribution { get; set; }

    public long? TotalDrawdown { get; set; }

    public bool? FundInvClient { get; set; }
}
