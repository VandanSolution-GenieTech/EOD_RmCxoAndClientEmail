using System;
using System.Collections.Generic;

namespace DataService.Models;

public partial class Wsportfolioperformance
{
    public int Id { get; set; }

    public int Clientid { get; set; }

    public int Schemeid { get; set; }

    public string? Schemename { get; set; }

    public string? Mode { get; set; }

    public string? Modestr { get; set; }

    public DateOnly? Fromdate { get; set; }

    public DateOnly? Todate { get; set; }

    public decimal? Beginmktval { get; set; }

    public decimal? Endmktval { get; set; }

    public decimal? Inflow { get; set; }

    public decimal? Outflow { get; set; }

    public decimal? Profit { get; set; }

    public decimal? Ror { get; set; }

    public decimal? Rorabs { get; set; }

    public decimal? Units { get; set; }

    public decimal? Nav { get; set; }

    public decimal? Realgain { get; set; }

    public decimal? Unrealgain { get; set; }

    public decimal? Priorgainloss { get; set; }

    public decimal? Income { get; set; }

    public decimal? Expenses { get; set; }

    public decimal? Accint { get; set; }

    public decimal? Commitamt { get; set; }

    public decimal? Distribution { get; set; }

    public decimal? Totaldrawdown { get; set; }

    public bool Fundinvclient { get; set; }

    public int? Bmseq { get; set; }

    public decimal? Bmror { get; set; }

    public decimal? Bmrorabs { get; set; }

    public string? BmName { get; set; }

    public string? Scope { get; set; }

    public int? Scopeid { get; set; }

    public string? Rortype { get; set; }

    public DateTime? Timestamp { get; set; }
}
