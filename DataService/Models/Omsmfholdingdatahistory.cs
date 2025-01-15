using System;
using System.Collections.Generic;

namespace DataService.Models;

public partial class Omsmfholdingdatahistory
{
    public int Id { get; set; }

    public string? ReferenceNumber { get; set; }

    public bool? IsNdpms { get; set; }

    public string? GroupId { get; set; }

    public string? OwnerId { get; set; }

    public string? ClientId { get; set; }

    public string? ClientCode { get; set; }

    public string? OrderType { get; set; }

    public string? Orderby { get; set; }

    public string? TransactionTypeName { get; set; }

    public string? AmcName { get; set; }

    public string? SchemeName { get; set; }

    public string? IsinCode { get; set; }

    public string? TrxType { get; set; }

    public string? FolioNo { get; set; }

    public decimal? Amount { get; set; }

    public decimal? Units { get; set; }

    public string? EiunCode { get; set; }

    public string? HoldingPattern { get; set; }

    public string? DematNo { get; set; }

    public string? SchemeCode { get; set; }

    public string? Mode { get; set; }

    public DateTime? TradeDate { get; set; }

    public int? Createdby { get; set; }

    public DateTime? Createdon { get; set; }

    public bool? IsActive { get; set; }

    public bool? Isallredeem { get; set; }

    public decimal? AvailableAmount { get; set; }

    public decimal? AvailableUnits { get; set; }

    public string? ClientName { get; set; }

    public string? Pan { get; set; }

    public string? AccountType { get; set; }

    public string? AccountStatus { get; set; }

    public string? Mobile { get; set; }

    public string? CxonNme { get; set; }

    public string? BankerName { get; set; }

    public string? BankAccountno { get; set; }

    public string? Ifsccode { get; set; }

    public bool? IsPrimaryBank { get; set; }

    public bool? IsBankPoa { get; set; }

    public string? DpId { get; set; }

    public string? DematStatus { get; set; }

    public bool? IsPrimaryDp { get; set; }

    public bool? IsPrimaryPoa { get; set; }

    public string? BankName { get; set; }

    public int? MakerId { get; set; }

    public DateTime? MakerTimestamp { get; set; }

    public string? Email { get; set; }

    public string? UccCode { get; set; }

    public string? UccCodeType { get; set; }

    public decimal? Totalavailableunits { get; set; }

    public decimal? Totalavailableamount { get; set; }

    public string? WsAccountCode { get; set; }

    public string? PmsSchemeName { get; set; }

    public string? Rejectionreason { get; set; }

    public string? ClientConsentMode { get; set; }

    public bool? Consentwaiver { get; set; }
}
