using System;
using System.Collections.Generic;

namespace DataService.Models;

public partial class Omstaxmaster
{
    public int Id { get; set; }

    public int? Entityid { get; set; }

    public string? Ordertype { get; set; }

    public decimal? Limitamount { get; set; }

    public bool? Isactive { get; set; }
}
