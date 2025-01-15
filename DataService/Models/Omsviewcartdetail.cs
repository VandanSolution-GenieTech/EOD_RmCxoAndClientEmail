using System;
using System.Collections.Generic;

namespace DataService.Models;

public partial class Omsviewcartdetail
{
    public int Id { get; set; }

    public string? Groupid { get; set; }

    public string? Ownerid { get; set; }

    public string? Clientid { get; set; }

    public string? Wsaccountcode { get; set; }

    public string? Pmsscheme { get; set; }

    public string? Ucccode { get; set; }

    public bool? Isndpms { get; set; }

    public int? Productid { get; set; }

    public int? Invid { get; set; }

    public int? Bankid { get; set; }

    public int? Dpid { get; set; }

    public string? Ordertype { get; set; }

    public string? Taxtype { get; set; }

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

    public int? Approverid { get; set; }

    public DateTime? Approvertimestamp { get; set; }

    public string? Remark { get; set; }

    public decimal? Yield { get; set; }

    public decimal? Facevalue { get; set; }

    public decimal? Interestrate { get; set; }

    public decimal? Tcwithoutstampduty { get; set; }

    public decimal? Stampduty { get; set; }

    public decimal? Taxamount { get; set; }

    public string? Settlment { get; set; }

    public DateTime? Tradedate { get; set; }

    public DateTime? Tradetime { get; set; }

    public string? Sendfor { get; set; }

    public string? Platform { get; set; }

    public bool? Isactive { get; set; }

    public bool? Isdeleted { get; set; }

    public string? Status { get; set; }

    public string? Referencenumber { get; set; }

    public int? Entityid { get; set; }

    public DateTime? Clientconsentdatetime { get; set; }

    public decimal? Tcwithstampduty { get; set; }

    public string? Clientname { get; set; }

    public string? Clientcode { get; set; }

    public string? Securityname { get; set; }

    public string? Paymentstatus { get; set; }

    public string? Stockstatus { get; set; }

    public string? Clientconsent { get; set; }

    public decimal? Amount { get; set; }

    public decimal? Totalconsideration { get; set; }

    public decimal? Price { get; set; }

    public string? Orderby { get; set; }

    public string? Marketorlimit { get; set; }

    public decimal? Listedeqprice { get; set; }

    public string? Accounttype { get; set; }

    public string? Classtradecode { get; set; }

    public string? Clientconsentmode { get; set; }

    public bool? Consentwaiver { get; set; }

    public string? Documentdata { get; set; }
}
