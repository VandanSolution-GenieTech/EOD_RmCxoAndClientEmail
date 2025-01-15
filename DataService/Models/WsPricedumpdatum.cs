using System;
using System.Collections.Generic;

namespace DataService.Models;

public partial class WsPricedumpdatum
{
    public string? PrimaryPricesource { get; set; }

    public double? SecondarySourcePrice { get; set; }

    public double? PrimarySourcePrice { get; set; }

    public string? SecondaryPricesource { get; set; }

    public string? Symbolcode { get; set; }

    public double? Closeindex { get; set; }

    public string? Nseseries { get; set; }

    public string? Isincode { get; set; }

    public string? Bsesymbol { get; set; }

    public string? Pricedate { get; set; }

    public string? Nsesymbol { get; set; }

    public int Id { get; set; }
}
