using System;
using System.Collections.Generic;

namespace DataService.Models;

public partial class VwIbeatsWbocdsl
{
    public int InvId { get; set; }

    public string? FormNo { get; set; }

    public string? AccountCode { get; set; }

    public int Products { get; set; }

    public int DpkycSw { get; set; }

    public string Cbecode { get; set; } = null!;

    public string Boid { get; set; } = null!;

    public string Dpid { get; set; } = null!;

    public string DpclntId { get; set; } = null!;

    public string? ProductNo { get; set; }

    public int PurchaseWaiver { get; set; }

    public int Bostatus { get; set; }

    public int BoaccCategory { get; set; }

    public string? BosubStatus { get; set; }

    public string? DpintRefNo { get; set; }

    public string? Botype { get; set; }

    public int BosubType { get; set; }

    public string AddrPreferenceFlag { get; set; } = null!;

    public string LifeStyleCode { get; set; } = null!;

    public int LegalStatusCode { get; set; }

    public int BofeesType { get; set; }

    public int LanguageCode { get; set; }

    public int Category4Code { get; set; }

    public int BankOption5 { get; set; }

    public string StaffRelativeOfDp { get; set; } = null!;

    public string StaffCode { get; set; } = null!;

    public int SecurityAccessCode { get; set; }

    public int BosettlmentPlanning { get; set; }

    public string Dpcmid { get; set; } = null!;

    public string Chid { get; set; } = null!;

    public int DpexcId { get; set; }

    public int ConfirmationWaived { get; set; }

    public string ExcClientId { get; set; } = null!;

    public string StmtCycleCode { get; set; } = null!;

    public int ElectronicDividend { get; set; }

    public int ElectronicConfirmation { get; set; }

    public int Rgessflag { get; set; }

    public int PledgeStandInstruFlag { get; set; }

    public int EmailRtadnFlag { get; set; }

    public int AnnualReportSend { get; set; }

    public string? DbankAccType { get; set; }

    public string? DbankMicr { get; set; }

    public string? DbankAccountNo { get; set; }

    public int DbankCurrency { get; set; }

    public string? DbankIfsccode { get; set; }

    public string DbankBranchNo { get; set; } = null!;

    public string? DbankName { get; set; }

    public string? DbankAddr { get; set; }

    public string DbankCity { get; set; } = null!;

    public string DbankState { get; set; } = null!;

    public string DbankCountry { get; set; } = null!;

    public string DbankPinCode { get; set; } = null!;

    public int SmsUploadFlag { get; set; }

    public string? SmsMobileNo { get; set; }

    public string? SmsEmailId { get; set; }

    public string EmailStmtFlag { get; set; } = null!;

    public string Casmode { get; set; } = null!;

    public string PreferredDpflag { get; set; } = null!;

    public string MentalDisability { get; set; } = null!;

    public string Dpamccode { get; set; } = null!;

    public int ChgPrf { get; set; }

    public string Bsdaflag { get; set; } = null!;

    public string BoidPan { get; set; } = null!;

    public byte[]? IsSelected { get; set; }

    public int DppurposeTypeCode { get; set; }

    public string DpclientGroup4 { get; set; } = null!;

    public int DppurposeType { get; set; }

    public string ServicingDpbranch { get; set; } = null!;

    public string BostmtCycleCode { get; set; } = null!;

    public byte[]? BostmtDispatchMode { get; set; }

    public byte[]? ClosureReasonCode { get; set; }

    public byte[]? GeoAreaCode { get; set; }

    public byte[]? SuspReason { get; set; }

    public byte[]? SuggDpscheme { get; set; }

    public int DptrustFlag { get; set; }

    public int PayOutDefault { get; set; }

    public int PayOutDefaultCx { get; set; }

    public int IssueDisbook { get; set; }

    public string SchemeAmcchrgMap { get; set; } = null!;

    public int ClientPoa { get; set; }

    public string Tdstatus { get; set; } = null!;

    public string TradingId { get; set; } = null!;

    public string ModChange { get; set; } = null!;

    public int RecordChanged { get; set; }

    public string EntryChannel { get; set; } = null!;

    public string BonafideFlag { get; set; } = null!;

    public string Leicode { get; set; } = null!;

    public int ModOfOper { get; set; }

    public int CommToBeSent { get; set; }

    public string PmssebiregNo { get; set; } = null!;

    public string PmsmanagerName { get; set; } = null!;

    public byte[]? LeiexpDate { get; set; }

    public byte[]? AncestralFlag { get; set; }

    public byte[]? Pmstype { get; set; }

    public string CustdPmsEmailId { get; set; } = null!;

    public byte[]? CustodianFlag { get; set; }

    public byte[]? DematGateway { get; set; }

    public int? NomineeShareEquality { get; set; }

    public string ClearingPanno { get; set; } = null!;

    public string Upiid { get; set; } = null!;

    public string DpintRefNo2 { get; set; } = null!;

    public int Saral { get; set; }

    public int Pmsflag { get; set; }
}
