using System;
using System.Collections.Generic;

namespace DataService.Models;

public partial class Omsscriptmaster
{
    public int Id { get; set; }

    public long? Instrumentsid { get; set; }

    public string? Isin { get; set; }

    public string? Companyname { get; set; }

    public string? Completenameofinstrument { get; set; }

    public string? Descriptioninnsdl { get; set; }

    public int? Issueprice { get; set; }

    public int? Facevalue { get; set; }

    public string? Interestrate { get; set; }

    public DateTime? Dateofallotment { get; set; }

    public DateTime? Redemptiondate { get; set; }

    public string? Couponrate { get; set; }

    public string? Frequencyoftheinterestpayment { get; set; }

    public DateTime? Lastinterestdate { get; set; }

    public DateTime? Nextinterestdate { get; set; }

    public string? Putcalloption { get; set; }

    public string? Certificatenos { get; set; }

    public string? Totalissuesize { get; set; }

    public string? Registerwithbpidno { get; set; }

    public string? Addresswithphysicalsecuritiesistobesent { get; set; }

    public string? Defaultedinredemption { get; set; }

    public string? Nameofdebenture { get; set; }

    public string? Creditratingagency { get; set; }

    public string? Remarks { get; set; }

    public string? Symbol { get; set; }

    public string? Isntrument { get; set; }

    public string? Expirydate { get; set; }

    public string? Strikeprice { get; set; }

    public string? Optiontype { get; set; }

    public string? Exchangetoken { get; set; }

    public string? Status { get; set; }

    public string? Createdby { get; set; }

    public string? Createdon { get; set; }

    public string? Modifiedby { get; set; }

    public string? Modifiedon { get; set; }

    public string? Timestamp { get; set; }
}
