using System;
using System.Collections.Generic;

namespace DataService.Models;

public partial class Wsperformancebysecurity
{
    public int Id { get; set; }

    public string? Recordfor { get; set; }

    public string? Astcls { get; set; }

    public string? Astclsname { get; set; }

    public string? Benchmarkcode { get; set; }

    public string? Benchmarkname { get; set; }

    public decimal? Beginmktval { get; set; }

    public decimal? Endmktval { get; set; }

    public decimal? Change { get; set; }

    public decimal? Netflow { get; set; }

    public decimal? Gain { get; set; }

    public decimal? Xirr { get; set; }

    public decimal? Bmxirr { get; set; }

    public int? Indexcol { get; set; }

    public string? Thirdpartyflag { get; set; }

    public string? Flagaif { get; set; }

    public string? Symtype { get; set; }

    public string? Symtypeori { get; set; }

    public decimal? Xirrabs { get; set; }

    public decimal? Bmxirrabs { get; set; }

    public decimal? Finalxirr { get; set; }

    public decimal? Finalbmxirr { get; set; }

    public DateOnly? Fromdate { get; set; }

    public DateOnly? Todate { get; set; }

    public string? Secdata { get; set; }

    public string? Datalevel { get; set; }

    public string? Periodopt { get; set; }

    public string? Categorycode { get; set; }

    public string? Categoryname { get; set; }

    public decimal? Balqty { get; set; }

    public decimal? Totalcost { get; set; }

    public decimal? Unrealgain { get; set; }

    public decimal? Gainlossper { get; set; }

    public decimal? Realgain { get; set; }

    public decimal? Priorgain { get; set; }

    public decimal? Price { get; set; }

    public decimal? Accruedincome { get; set; }

    public decimal? Income { get; set; }

    public DateOnly? Priceon { get; set; }

    public decimal? Inflow { get; set; }

    public decimal? Outflow { get; set; }

    public decimal? Bm1gain { get; set; }

    public decimal? Netinflow { get; set; }

    public DateOnly? Startdate { get; set; }

    public DateOnly? Enddate { get; set; }

    public decimal? Growth { get; set; }

    public string? Scopestr { get; set; }

    public string? Scope { get; set; }

    public int? Scopeid { get; set; }

    public int? Astclsseq { get; set; }

    public string? Finalxirrstr { get; set; }

    public string? Finalbmxirrstr { get; set; }

    public string? Beginmktvalstr { get; set; }

    public string? Endmktvalstr { get; set; }

    public string? Changestr { get; set; }

    public string? Netflowstr { get; set; }

    public string? Gainstr { get; set; }

    public string? Xirrstr { get; set; }

    public string? Bmxirrstr { get; set; }

    public string? Xirrabsstr { get; set; }

    public string? Bmxirrabsstr { get; set; }

    public DateTime? Timestamp { get; set; }
}
