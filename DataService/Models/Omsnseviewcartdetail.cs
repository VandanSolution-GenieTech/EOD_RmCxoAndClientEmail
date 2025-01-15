using System;
using System.Collections.Generic;

namespace DataService.Models;

public partial class Omsnseviewcartdetail
{
    public int Id { get; set; }

    public int? Invid { get; set; }

    public string? Ordertype { get; set; }

    public int? Scriptid { get; set; }

    public string? Isincode { get; set; }

    public decimal? Remainingquantity { get; set; }

    public decimal? Flowprice { get; set; }

    public string? Buyselltype { get; set; }

    public decimal? Quantitybooked { get; set; }

    public decimal? Actualpriceordered { get; set; }

    public decimal? Marginpercentage { get; set; }

    public int? Makerid { get; set; }

    public DateTime? Makertimetamp { get; set; }

    public bool? Isactive { get; set; }

    public bool? Isdeleted { get; set; }

    public string? Status { get; set; }

    public int? BankId { get; set; }

    public string? DpId { get; set; }

    public string? Clientname { get; set; }

    public string? Clientcode { get; set; }

    public string? Securityname { get; set; }

    public int? Entityid { get; set; }

    public decimal? Amount { get; set; }

    public int? Productid { get; set; }

    public decimal? Tcsamount { get; set; }

    public decimal? Tdsamount { get; set; }

    public decimal? Price { get; set; }

    public decimal? StampDuty { get; set; }

    public string? TaxType { get; set; }

    public decimal? TaxAmount { get; set; }

    public decimal? TotalConsideration { get; set; }

    public string? Groupid { get; set; }

    public string? Ownerid { get; set; }

    public string? Clientid { get; set; }

    public string? Wsaccountcode { get; set; }

    public string? Pmsschemename { get; set; }

    public string? Ucccode { get; set; }

    public bool? Isndpms { get; set; }

    public DateTime? CreatedOn { get; set; }
}
