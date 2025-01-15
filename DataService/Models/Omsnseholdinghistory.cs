using System;
using System.Collections.Generic;

namespace DataService.Models;

public partial class Omsnseholdinghistory
{
    public int Id { get; set; }

    public string? Groupid { get; set; }

    public string? Ownerid { get; set; }

    public string? Clientid { get; set; }

    public string? Wsaccountcode { get; set; }

    public string? Pmsscheme { get; set; }

    public string? Ucccode { get; set; }

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

    public decimal? Tcsamount { get; set; }

    public decimal? Tdsamount { get; set; }

    public bool? Isactiontakenfrombondteam { get; set; }

    public string? Mobile { get; set; }

    public string? Email { get; set; }

    public DateTime? Issuancedate { get; set; }

    public DateTime? Maturitydate { get; set; }

    public decimal? Maturityamount { get; set; }

    public DateTime? Dealdate { get; set; }

    public DateTime? Valuedate { get; set; }

    public DateTime? Calldate { get; set; }

    public decimal? Accruedinterest { get; set; }

    public decimal? Maturityprice { get; set; }

    public decimal? Maturityvalue { get; set; }

    public string? InterestPaymentOnMaturity { get; set; }

    public string? PaymentFrequency { get; set; }

    public DateTime? Lastinterestdate { get; set; }

    public string? Seller { get; set; }

    public string? Buyer { get; set; }

    public string? Entityname { get; set; }

    public string? Documentstatus { get; set; }

    public string? Limits { get; set; }

    public string? Market { get; set; }

    public decimal? Listedeqprice { get; set; }

    public decimal? Totalconsideration { get; set; }

    public string? Entityshortname { get; set; }

    public string? Pan { get; set; }

    public string? Rejectionreason { get; set; }

    public string? Rejectionremark { get; set; }

    public bool? IsFmapprovalPending { get; set; }

    public string? Accounttype { get; set; }

    public bool? Bankpoa { get; set; }

    public string? Dealid { get; set; }

    public bool? Isndpms { get; set; }
}
