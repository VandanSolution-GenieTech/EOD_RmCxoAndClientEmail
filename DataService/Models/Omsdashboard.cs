using System;
using System.Collections.Generic;

namespace DataService.Models;

public partial class Omsdashboard
{
    public int Id { get; set; }

    public string? Referenceno { get; set; }

    public string? Clientname { get; set; }

    public string? Securityname { get; set; }

    public string? Isinno { get; set; }

    public int? Instrumentsid { get; set; }

    public string? Calltype { get; set; }

    public decimal? Quantity { get; set; }

    public decimal? Totalconsideration { get; set; }

    public string? Clientconsent { get; set; }

    public string? Paymentstatus { get; set; }

    public string? Stockstatus { get; set; }

    public int? Tradestatus { get; set; }

    public int? Createdby { get; set; }

    public DateTime? Createdon { get; set; }

    public int? Modifiedby { get; set; }

    public DateTime? Modifiedon { get; set; }

    public DateTime? Tradeexeccutiondate { get; set; }

    public bool? Isalldocumentsuploaded { get; set; }

    public bool? Ispaymentuploaded { get; set; }

    public int? Paymentuploadedby { get; set; }

    public DateTime? Paymentuploadedtimestamp { get; set; }

    public bool? Isstocktrnasferuploaded { get; set; }

    public int? Stocktransferuploadedby { get; set; }

    public DateTime? Stocktransferuploadedtimestamp { get; set; }

    public bool? Isnseuploaded { get; set; }

    public int? Nseuploadedby { get; set; }

    public DateTime? Nseuploadedtimestamp { get; set; }

    public bool? Isalldocumentsuploadedverified { get; set; }

    public int? Alldocumentsuploadedverifiedby { get; set; }

    public DateTime? Alldocumentsuploadedverifiedtimestamp { get; set; }

    public bool? Ispaymentuploadedverified { get; set; }

    public int? Paymentuploadedverifiedby { get; set; }

    public DateTime? Paymentuploadedverifiedtimestamp { get; set; }

    public bool? Isstocktrnasferuploadedverified { get; set; }

    public int? Stocktrnasferuploadedverifiedby { get; set; }

    public DateTime? Stocktrnasferuploadedverifiedtimestamp { get; set; }

    public bool? Isactive { get; set; }

    public bool? Isdeleted { get; set; }
}
