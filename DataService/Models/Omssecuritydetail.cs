using System;
using System.Collections.Generic;

namespace DataService.Models;

public partial class Omssecuritydetail
{
    public int Id { get; set; }

    public int? Instrumentid { get; set; }

    public string? Isin { get; set; }

    public string? Symbolid { get; set; }

    public string? Symbolname { get; set; }

    public string? Astclsname { get; set; }

    public string? Symtypename { get; set; }

    public string? Detailtypename { get; set; }

    public string? Sectorname { get; set; }

    public decimal? Sharecapital { get; set; }

    public decimal? Facevalue { get; set; }

    public decimal? Strikeprice { get; set; }

    public string? Internalsymbolcode { get; set; }

    public string? Refsymbol1 { get; set; }

    public string? Issuer { get; set; }

    public string? Dimcode2 { get; set; }

    public string? Dimname2 { get; set; }

    public string? Dimcode6 { get; set; }

    public string? Dimname6 { get; set; }

    public string? Dimcode7 { get; set; }

    public string? Dimname7 { get; set; }

    public string? Classify1 { get; set; }

    public decimal? Roundlot { get; set; }

    public string? Activeind { get; set; }

    public string? Nseseries { get; set; }

    public string? Maturitydatedmp { get; set; }

    public ulong? Isactive { get; set; }

    public DateTime? Createdon { get; set; }
}
