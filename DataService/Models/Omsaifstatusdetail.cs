using System;
using System.Collections.Generic;

namespace DataService.Models;

public partial class Omsaifstatusdetail
{
    public int Id { get; set; }

    public int? Orderhistoryid { get; set; }

    public string? Clientconsent { get; set; }

    public DateTime? Clientconsenttimestamp { get; set; }

    public string? Paymentstatus { get; set; }

    public DateTime? Paymentstatustimestamp { get; set; }

    public string? Stockstatus { get; set; }

    public DateTime? Stockstatustimestamp { get; set; }

    public string? Documentstatus { get; set; }

    public DateTime? Documentstatustimestamp { get; set; }

    public string? Finalstatus { get; set; }

    public DateTime? Finalstatustimetamp { get; set; }

    public int? Makerid { get; set; }

    public DateTime? Makertimestamp { get; set; }

    public int? Approverid { get; set; }

    public DateTime? Approvertimestamp { get; set; }

    public bool? Isactive { get; set; }

    public string? Dealid { get; set; }

    public bool? Istrademailsent { get; set; }

    public DateTime? Tradedate { get; set; }

    public string? ClientCode { get; set; }

    public bool? Isfmapprovalpending { get; set; }

    public DateTime? Fmapprovaldatetime { get; set; }

    public string? Fmapprovalstatus { get; set; }

    public string? Rejectionremark { get; set; }

    public string? Rejectionreason { get; set; }

    public string? Clientconsentmode { get; set; }

    public bool? Consentwaiver { get; set; }

    public DateTime? Fmapprovaltimestamp { get; set; }

    public int? Fmapprovaluserid { get; set; }

    public string? Ipaddress { get; set; }
}
