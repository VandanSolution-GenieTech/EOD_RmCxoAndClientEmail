using System;
using System.Collections.Generic;

namespace DataService.Models;

public partial class Omsdealerdashboardatainsertion
{
    public int Id { get; set; }

    public int? Orderhistoryid { get; set; }

    public int? Quantitybooked { get; set; }

    public decimal? Actualpriceordered { get; set; }

    public decimal? Totalconsideration { get; set; }

    public int? Approverid { get; set; }

    public bool? Isactive { get; set; }

    public DateTime? Approvertimestamp { get; set; }
}
