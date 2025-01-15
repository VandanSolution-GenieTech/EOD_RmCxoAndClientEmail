using System;
using System.Collections.Generic;

namespace DataService.Models;

public partial class Omsfixedincomedetail
{
    public int Id { get; set; }

    public int Orderhistoryid { get; set; }

    public string? Buyselltype { get; set; }

    public int? Scripid { get; set; }

    public int? Quantitybooked { get; set; }

    public decimal? Totalconsideration { get; set; }

    public string? InterestPaymentOnMaturity { get; set; }

    public string? PaymentFrequency { get; set; }

    public int? Makerid { get; set; }

    public DateTime? Makertimestamp { get; set; }

    public int? Approverid { get; set; }

    public DateTime? Approvertimestamp { get; set; }

    public bool? Isactive { get; set; }

    public decimal? Actualpriceordered { get; set; }

    public string? Reason { get; set; }

    public string? Remark { get; set; }

    public decimal? Facevalue { get; set; }

    public bool? Ismatchedwithdealtransact { get; set; }

    public DateTime? Settlmentdate { get; set; }

    public string? Dealid { get; set; }

    public DateTime? Reconcilationtime { get; set; }
}
