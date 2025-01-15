using System;
using System.Collections.Generic;

namespace DataService.Models;

public partial class EsigncordinatemasterUpdate
{
    public int Id { get; set; }

    public int? Productid { get; set; }

    public int Clienttypeid { get; set; }

    public int Pdftype { get; set; }

    public int? Holdercount { get; set; }

    public bool Isadditionalsigner { get; set; }

    public int? Additionalsignerrank { get; set; }

    public int? Holderrankid { get; set; }

    public int? Pagenumber { get; set; }

    public decimal? Llx { get; set; }

    public decimal? Lly { get; set; }

    public decimal? Urx { get; set; }

    public decimal? Ury { get; set; }

    public bool? Isactive { get; set; }
}
