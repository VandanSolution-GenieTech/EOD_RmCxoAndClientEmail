using System;
using System.Collections.Generic;

namespace DataService.Models;

public partial class Clientwiseaum
{
    public int Id { get; set; }

    public string? Accountcode { get; set; }

    public DateOnly? Valuedate { get; set; }

    public decimal? Aum { get; set; }

    public int? Clientid { get; set; }

    public string? Clientname { get; set; }

    public DateTime? Todate { get; set; }

    public string? Scope { get; set; }

    public string? Scopeid { get; set; }
}
