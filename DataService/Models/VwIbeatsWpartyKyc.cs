using System;
using System.Collections.Generic;

namespace DataService.Models;

public partial class VwIbeatsWpartyKyc
{
    public int InvId { get; set; }

    public string? AccountCode { get; set; }

    public string? Prefix { get; set; }

    public string? FullAcName { get; set; }

    public string? FormNo { get; set; }

    public string? FirstName { get; set; }

    public string? MiddleName { get; set; }

    public string? LastName { get; set; }

    public string? FatherName { get; set; }

    public string? BirthDate { get; set; }

    public string? Education { get; set; }

    public string? Occupation { get; set; }

    public string Nationality { get; set; } = null!;

    public string? EmplName { get; set; }

    public string EmplBusiness { get; set; } = null!;

    public string EmplAddr { get; set; } = null!;

    public string? EmplContact { get; set; }

    public string? NonIndividualName { get; set; }

    public string? IncorporationDate { get; set; }

    public string? CommencementDate { get; set; }

    public string CompanyBusiness { get; set; } = null!;

    public string? CompanyRegNo { get; set; }

    public string? RocregDate { get; set; }

    public string RegdOffAddr { get; set; } = null!;

    public string SebiregNo { get; set; } = null!;

    public string SebisubAccRegNo { get; set; } = null!;

    public DateTime SebiregDate { get; set; }

    public DateTime SebiregEndDate { get; set; }

    public int Nritype { get; set; }

    public string RbirefNo { get; set; } = null!;

    public DateTime RbiapprovalDate { get; set; }

    public string? Faddr { get; set; }

    public string? Fcity { get; set; }

    public string? Fstate { get; set; }

    public string Fcountry { get; set; } = null!;

    public string? FpinCode { get; set; }

    public string Fisdcode { get; set; } = null!;

    public string Fstdcode { get; set; } = null!;

    public string FphoneList { get; set; } = null!;

    public string FfaxList { get; set; } = null!;

    public string FemailList { get; set; } = null!;

    public string? Paddr1 { get; set; }

    public string Paddr2 { get; set; } = null!;

    public string Paddr3 { get; set; } = null!;

    public string Paddr4 { get; set; } = null!;

    public string? Pcity { get; set; }

    public string? Pstate { get; set; }

    public string Pcountry { get; set; } = null!;

    public string? PpinCode { get; set; }

    public string Pisdcode { get; set; } = null!;

    public string Pstdcode { get; set; } = null!;

    public string PphoneList { get; set; } = null!;

    public string PfaxList { get; set; } = null!;

    public int IntroType { get; set; }

    public string IntroFirstName { get; set; } = null!;

    public string IntroMiddleName { get; set; } = null!;

    public string IntroLastName { get; set; } = null!;

    public string IntroAddr { get; set; } = null!;

    public string IntroContact { get; set; } = null!;

    public string IntroUcc { get; set; } = null!;

    public string IntroDpaccount { get; set; } = null!;

    public int AmlriskGroup { get; set; }

    public int Cscategory { get; set; }

    public string InpersonVerification { get; set; } = null!;

    public int IgnoreUcc { get; set; }

    public int EntryId { get; set; }

    public DateTime EntryDate { get; set; }

    public int KycReqNo { get; set; }

    public string AccSuspensionFlag { get; set; } = null!;

    public string AccStatusRemarks { get; set; } = null!;

    public byte[]? BosuspensionDate { get; set; }

    public string SuspInitiatedBy { get; set; } = null!;

    public byte[]? ActivationDtm { get; set; }

    public byte[]? ClosureDate { get; set; }

    public byte[]? ClosureApprovalDate { get; set; }

    public string ClosureInitiatedBy { get; set; } = null!;

    public string CorrsAddrAsPermanent { get; set; } = null!;

    public int IncomeNetworthFlag { get; set; }

    public byte[]? GrossAnnualIncDate { get; set; }

    public int GrossAnnualIncRange { get; set; }

    public byte[]? Networth { get; set; }

    public int LanguageCode { get; set; }

    public string LifeStyleCode { get; set; } = null!;

    public string ProofNumber { get; set; } = null!;

    public string ProofType { get; set; } = null!;

    public int ServiceType { get; set; }

    public int NrisubType { get; set; }

    public int NonIndForeignerFlag { get; set; }

    public string SuggestedCode { get; set; } = null!;

    public string PanexemptionCode { get; set; } = null!;

    public string PanverificationCode { get; set; } = null!;

    public int AcquisitionBy { get; set; }

    public string AcquisitionName { get; set; } = null!;

    public string AcquisitionRlmcode { get; set; } = null!;

    public string RelationshipRlmcode { get; set; } = null!;

    public string ServicingSubBroker { get; set; } = null!;

    public string ServicingBranch { get; set; } = null!;

    public int EditId { get; set; }

    public DateTime EditDtm { get; set; }

    public string Faddr1 { get; set; } = null!;

    public string Faddr2 { get; set; } = null!;

    public string Faddr3 { get; set; } = null!;

    public string Faddr4 { get; set; } = null!;

    public int AccSw { get; set; }

    public string SuggBrokSlab { get; set; } = null!;

    public string SuggDpscheme { get; set; } = null!;

    public int Pepcode { get; set; }

    public string GenderCode { get; set; } = null!;

    public string MaritalStatusCode { get; set; } = null!;

    public string NationalityCode { get; set; } = null!;

    public string OccupationCode { get; set; } = null!;

    public string AccStatusCode { get; set; } = null!;

    public string GrossAnnualIncRangeCode { get; set; } = null!;

    public string ServiceTypeCode { get; set; } = null!;

    public int RelationshipTypeCode { get; set; }

    public string IsdcodeOffice { get; set; } = null!;

    public string StdcodeOffice { get; set; } = null!;

    public string PhoneListOffice { get; set; } = null!;

    public string? Cin { get; set; }

    public int IsCin { get; set; }

    public byte[]? NetWorthDate { get; set; }

    public string RegisteringAuthority { get; set; } = null!;

    public string PlaceOfRegistration { get; set; } = null!;

    public string EqbrokCode { get; set; } = null!;

    public string FobrokCode { get; set; } = null!;

    public string CdsbrokCode { get; set; } = null!;

    public string CxbrokCode { get; set; } = null!;

    public string Eqbrok1 { get; set; } = null!;

    public string Eqbrok2 { get; set; } = null!;

    public string Eqbrok3 { get; set; } = null!;

    public string Fobrok1 { get; set; } = null!;

    public string Fobrok2 { get; set; } = null!;

    public string Fobrok3 { get; set; } = null!;

    public string Cdsbrok1 { get; set; } = null!;

    public string Cdsbrok2 { get; set; } = null!;

    public string Cdsbrok3 { get; set; } = null!;

    public string Cxbrok1 { get; set; } = null!;

    public string Cxbrok2 { get; set; } = null!;

    public string Cxbrok3 { get; set; } = null!;

    public string FstateCode { get; set; } = null!;

    public string FcountryCode { get; set; } = null!;

    public string PstateCode { get; set; } = null!;

    public string PcountryCode { get; set; } = null!;

    public string IssuePlaceofProof { get; set; } = null!;

    public byte[]? IssueDateofProof { get; set; }

    public string PlaceOfIncorporation { get; set; } = null!;

    public string EmplAddr1 { get; set; } = null!;

    public string EmplAddr2 { get; set; } = null!;

    public string EmplAddr3 { get; set; } = null!;

    public string EmplCity { get; set; } = null!;

    public string EmplState { get; set; } = null!;

    public string EmplCountry { get; set; } = null!;

    public string EmplPinCode { get; set; } = null!;

    public string EmplStateCode { get; set; } = null!;

    public string EmplCountryCode { get; set; } = null!;

    public string RegAddr1 { get; set; } = null!;

    public string RegAddr2 { get; set; } = null!;

    public string RegAddr3 { get; set; } = null!;

    public string RegCity { get; set; } = null!;

    public string RegState { get; set; } = null!;

    public string RegCountry { get; set; } = null!;

    public string RegPinCode { get; set; } = null!;

    public string RegStateCode { get; set; } = null!;

    public int RegCountryCode { get; set; }

    public int KycReqStatus { get; set; }

    public int TradingPoasw { get; set; }

    public int TradingPoasw2 { get; set; }

    public string ResidentStatus { get; set; } = null!;

    public int TradingStatus { get; set; }

    public int DematStatus { get; set; }

    public byte[]? TradingPoadateFund { get; set; }

    public byte[]? TradingPoadateSec { get; set; }

    public string RegAddr4 { get; set; } = null!;

    public string EmplAddr4 { get; set; } = null!;

    public string PlaceOfBirth { get; set; } = null!;

    public string ControllingPersonTypeFatca { get; set; } = null!;

    public string? AddressTypeFatca { get; set; }

    public int SetDpidprefix { get; set; }

    public int TaxResDeclrF61b { get; set; }

    public string CountryCodeF61b { get; set; } = null!;

    public string IpvName { get; set; } = null!;

    public string IpvDesg { get; set; } = null!;

    public string IpvOrgan { get; set; } = null!;

    public string AccountType { get; set; } = null!;

    public string CkycNo { get; set; } = null!;

    public string FlagFs { get; set; } = null!;

    public string? FsfirstName { get; set; }

    public string? FslastName { get; set; }

    public string? FsmiddleName { get; set; }

    public string? Fsprefix { get; set; }

    public string MaidenFirstName { get; set; } = null!;

    public string MaidenFullAcName { get; set; } = null!;

    public string MaidenLastName { get; set; } = null!;

    public string MaidenMiddleName { get; set; } = null!;

    public string MaidenPrefix { get; set; } = null!;

    public string MotherFirstName { get; set; } = null!;

    public string MotherFullAcName { get; set; } = null!;

    public string MotherLastName { get; set; } = null!;

    public string MotherMiddleName { get; set; } = null!;

    public string MotherPrefix { get; set; } = null!;

    public int Pdistrict { get; set; }

    public string Fdistrict { get; set; } = null!;

    public string PaddressTypeF61b { get; set; } = null!;

    public string FaddressTypeF61b { get; set; } = null!;

    public string RegAddressTypeF61b { get; set; } = null!;

    public string RegDistrict { get; set; } = null!;

    public string EmplAddressTypeF61b { get; set; } = null!;

    public string EmplDistrict { get; set; } = null!;

    public string FaddressTypeF61bDesc { get; set; } = null!;

    public string PaddressTypeF61bDesc { get; set; } = null!;

    public string GstInNo { get; set; } = null!;

    public int IsRegCorr { get; set; }

    public int IsRegPerm { get; set; }

    public int IsForgnCorr { get; set; }

    public int IsForgnPerm { get; set; }

    public string Fostatus { get; set; } = null!;

    public byte[]? EqminOrderBrokAmt { get; set; }

    public int Sebimtfflag { get; set; }

    public string Leicode { get; set; } = null!;

    public int DormantType { get; set; }

    public string ChequePrintName { get; set; } = null!;

    public string CkycupdateFlagList { get; set; } = null!;

    public string AadhaarEnrollmentNo { get; set; } = null!;

    public string AuthPerson { get; set; } = null!;

    public string StpreceiverId { get; set; } = null!;

    public string TradeMethod { get; set; } = null!;

    public string Sstate { get; set; } = null!;

    public string SstateCode { get; set; } = null!;

    public string Vidno { get; set; } = null!;

    public int VisaType { get; set; }

    public string Cdcnumber { get; set; } = null!;

    public byte[]? NrivisaDate { get; set; }

    public string Sprefix { get; set; } = null!;

    public string SfirstName { get; set; } = null!;

    public string SlastName { get; set; } = null!;

    public string SmiddleName { get; set; } = null!;

    public int EqmaxOrderBrokAmt { get; set; }

    public string Relationship1Rlmcode { get; set; } = null!;

    public string Efe { get; set; } = null!;

    public string Cpcode { get; set; } = null!;

    public string CustId { get; set; } = null!;

    public byte[]? AccOpenChgAmt { get; set; }

    public byte[]? AccClosChgAmt { get; set; }

    public byte[]? SrvChg1Amt { get; set; }

    public byte[]? SrvChg2Amt { get; set; }

    public byte[]? SrvChg3Amt { get; set; }

    public byte[]? SrvChg4Amt { get; set; }

    public byte[]? SrvChg5Amt { get; set; }

    public int Products { get; set; }

    public int InstSw { get; set; }

    public int KycFormVersion { get; set; }

    public int KraregCbecode { get; set; }

    public int MdobincDate { get; set; }

    public string MbirthDate { get; set; } = null!;

    public string MincorporationDate { get; set; } = null!;

    public int IgnoreDoc { get; set; }

    public string CsriskCode { get; set; } = null!;

    public string McommencementDate { get; set; } = null!;

    public int Egr { get; set; }

    public string MrocregDate { get; set; } = null!;

    public int PcityCtr { get; set; }

    public int RcityCtr { get; set; }

    public int KrakycMode { get; set; }

    public int OptForUpi { get; set; }

    public string ClientNameDesc { get; set; } = null!;
}
