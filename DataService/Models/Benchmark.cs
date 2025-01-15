using System;
using System.Collections.Generic;

namespace DataService.Models;

public partial class Benchmark
{
    public int Id { get; set; }

    public int? Bmseq { get; set; }

    public decimal? Bmrorm { get; set; }

    public decimal? Bmrormabs { get; set; }

    public string? Bmname { get; set; }

    public bool? Isactive { get; set; }

    public bool? Isdeleted { get; set; }

    public DateTime? Todate { get; set; }
}
