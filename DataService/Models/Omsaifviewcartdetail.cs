using System;
using System.Collections.Generic;

namespace DataService.Models;

public partial class Omsaifviewcartdetail
{
    public int Id { get; set; }

    public int? Entityid { get; set; }

    public string? Groupid { get; set; }

    public string? Ownerid { get; set; }

    public string? Clientid { get; set; }

    public string? Clientcode { get; set; }

    public string? Wsaccountcode { get; set; }

    public string? Pmsscheme { get; set; }

    public string? Ucccode { get; set; }

    public bool? Isndpms { get; set; }

    public string? Ordertype { get; set; }

    public string? Amcname { get; set; }

    public string? Schmename { get; set; }

    public string? Isincode { get; set; }

    public string? Folio { get; set; }

    public string? Trxtype { get; set; }

    public string? Manufacturer { get; set; }

    public string? Class { get; set; }

    public decimal? Commitmentamount { get; set; }

    public decimal? Amount { get; set; }

    public decimal? Price { get; set; }

    public decimal? Setupfee { get; set; }

    public decimal? Equilizationamount { get; set; }

    public decimal? Units { get; set; }

    public DateTime? Tradedate { get; set; }

    public DateTime? Createdon { get; set; }

    public int? Createdby { get; set; }

    public string? Clientname { get; set; }

    public string? Pan { get; set; }

    public string? Acounttype { get; set; }

    public string? Mobile { get; set; }

    public string? Cxoname { get; set; }

    public string? Bankername { get; set; }

    public string? Bankaccountno { get; set; }

    public string? Ifsccode { get; set; }

    public bool? Isprimarybank { get; set; }

    public bool? Isbankpoa { get; set; }

    public string? Dpid { get; set; }

    public string? Dematstatus { get; set; }

    public bool? Isprimarydp { get; set; }

    public bool? Isprimarypoa { get; set; }

    public string? Bankname { get; set; }

    public string? Email { get; set; }

    public bool? Isactive { get; set; }

    public string? Clientconsentmode { get; set; }

    public bool? Consentwaiver { get; set; }

    public string? Documentdata { get; set; }
}
