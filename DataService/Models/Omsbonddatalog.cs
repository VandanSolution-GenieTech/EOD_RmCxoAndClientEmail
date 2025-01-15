using System;
using System.Collections.Generic;

namespace DataService.Models;

public partial class Omsbonddatalog
{
    public int Id { get; set; }

    public int? Userid { get; set; }

    public DateTime? Timestamp { get; set; }

    public string? Isinno { get; set; }

    public decimal? Quantity { get; set; }

    public DateTime? Valuedate { get; set; }

    public string? Securityname { get; set; }

    public decimal? Facevalue { get; set; }

    public DateTime? Issuancedate { get; set; }

    public DateTime? Maturitydate { get; set; }

    public decimal? Maturityamount { get; set; }

    public DateTime? Lastinterestpaymentdate { get; set; }

    public int? Noofdays { get; set; }

    public decimal? Accruedinterest { get; set; }

    public decimal? Price { get; set; }

    public DateTime? Pricedate { get; set; }

    public decimal? Maturityprice { get; set; }
}
