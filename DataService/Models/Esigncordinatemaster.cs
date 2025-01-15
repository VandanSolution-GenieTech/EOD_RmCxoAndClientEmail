using System;
using System.Collections.Generic;

namespace DataService.Models;

public partial class Esigncordinatemaster
{
    public int Id { get; set; }

    public int? Productid { get; set; }

    public int? Holderrankid { get; set; }

    public int? Pagenumber { get; set; }

    public decimal? Llx { get; set; }

    public decimal? Lly { get; set; }

    public decimal? Urx { get; set; }

    public decimal? Ury { get; set; }

    public bool? Isactive { get; set; }
}
