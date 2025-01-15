using System;
using System.Collections.Generic;

namespace DataService.Models;

public partial class Wsportfolioholding
{
    public int Id { get; set; }

    public DateTime Ondate { get; set; }

    public int Code { get; set; }

    public string? Description { get; set; }

    public string? Astcls { get; set; }

    public string? Astclsname { get; set; }

    public string? Category { get; set; }

    public string? Categoryname { get; set; }

    public string? Symbolcode { get; set; }

    public string? Symbolname { get; set; }

    public string? Mintrandate { get; set; }

    public decimal Units { get; set; }

    public decimal Mktval { get; set; }

    public decimal Nav { get; set; }

    public decimal Accruedint { get; set; }

    public decimal Income { get; set; }

    public decimal Totalcost { get; set; }

    public decimal Totalgain { get; set; }

    public decimal Gainperc { get; set; }

    public decimal Xirryield { get; set; }

    public decimal Assetsperc { get; set; }

    public int Level { get; set; }

    public string? Thirdpartyflag { get; set; }

    public decimal Wtdavgday { get; set; }

    public string? Filterby { get; set; }

    public string? Filtervalue { get; set; }

    public DateTime? Timestamp { get; set; }
}
