using System;
using System.Collections.Generic;

namespace DataService.Models;

public partial class VwIbeatsWpartyMaster
{
    public int InvId { get; set; }

    public int Products { get; set; }

    public string? AccountCode { get; set; }

    public int KycRefNo { get; set; }

    public string? KaccType { get; set; }

    public int AccCategory { get; set; }

    public string? AccountName { get; set; }

    public string? ParentAcCode { get; set; }

    public string FamilyCode { get; set; } = null!;

    public string ClientGroup1 { get; set; } = null!;

    public string ClientGroup2 { get; set; } = null!;

    public string ClientGroup3 { get; set; } = null!;

    public string ClientGroup4 { get; set; } = null!;

    public string DealerAcCode { get; set; } = null!;

    public string TclientGroup1 { get; set; } = null!;

    public string TclientGroup2 { get; set; } = null!;

    public string TclientGroup3 { get; set; } = null!;

    public int SvTreeId { get; set; }

    public string Channel1 { get; set; } = null!;

    public string Channel2 { get; set; } = null!;

    public string Channel3 { get; set; } = null!;

    public string Channel4 { get; set; } = null!;

    public string MapInId { get; set; } = null!;

    public string LinkAcCode1 { get; set; } = null!;

    public string LinkAcCode2 { get; set; } = null!;

    public string? Addr1 { get; set; }

    public string Addr2 { get; set; } = null!;

    public string Addr3 { get; set; } = null!;

    public string Addr4 { get; set; } = null!;

    public string? City { get; set; }

    public string? Cstate { get; set; }

    public string Country { get; set; } = null!;

    public string? PinCode { get; set; }

    public string Isdcode { get; set; } = null!;

    public string Stdcode { get; set; } = null!;

    public string PhoneList { get; set; } = null!;

    public string FaxList { get; set; } = null!;

    public string? MobileList { get; set; }

    public string? SmsmobileList { get; set; }

    public string? ToEmailList { get; set; }

    public string CcEmailList { get; set; } = null!;

    public string BccEmailList { get; set; } = null!;

    public string EntryChannel { get; set; } = null!;

    public int LedgerType { get; set; }

    public int EditId { get; set; }

    public DateTime EditDtm { get; set; }

    public int MakerId { get; set; }

    public DateTime MakerDtm { get; set; }

    public int KycReqNo { get; set; }

    public string CstateCode { get; set; } = null!;

    public string CountryCode { get; set; } = null!;

    public string AdharNo { get; set; } = null!;

    public string AccessType { get; set; } = null!;

    public int KycReqStatus { get; set; }

    public string? FormNo { get; set; }

    public string? Panno { get; set; }

    public string FloginId { get; set; } = null!;

    public string DateofDeclaration { get; set; } = null!;

    public string District { get; set; } = null!;

    public string KycverificationBranch { get; set; } = null!;

    public DateOnly KycverificationDate { get; set; }

    public string KycverificationEmpcode { get; set; } = null!;

    public string OrganisationCode { get; set; } = null!;

    public string PlaceofDeclaration { get; set; } = null!;

    public string TypeofDocumentSubmitted { get; set; } = null!;

    public string AddressTypeF61b { get; set; } = null!;

    public string AddressTypeF61bDesc { get; set; } = null!;

    public string MobileRelationshipCode { get; set; } = null!;

    public string EmailRelationshipCode { get; set; } = null!;

    public string MobileRelationshipName { get; set; } = null!;

    public string EmailRelationshipName { get; set; } = null!;

    public int LegalStatus { get; set; }

    public string Paccountcode { get; set; } = null!;

    public string MobileRelationPaccCode { get; set; } = null!;

    public string EmailRelationPaccCode { get; set; } = null!;

    public int KaccType1 { get; set; }

    public string MstSchemeCode { get; set; } = null!;

    public string PanresponseStatus { get; set; } = null!;

    public string PanfullAcName { get; set; } = null!;

    public int KaccType2 { get; set; }

    public string Panex { get; set; } = null!;

    public string AddnCcEmailList { get; set; } = null!;

    public string AddnBccEmailList { get; set; } = null!;

    public int CcityCtr { get; set; }

    public string TclientGroup4 { get; set; } = null!;

    public string TclientGroup5 { get; set; } = null!;

    public string TclientGroup6 { get; set; } = null!;

    public string CashFlowGroup { get; set; } = null!;
}
