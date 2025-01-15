using System;
using System.Collections.Generic;

namespace DataService.Models;

public partial class VwIbeatsWboaddr
{
    public int InvId { get; set; }

    public string? FormNo { get; set; }

    public string? AccountCode { get; set; }

    public int Products { get; set; }

    public long EditId { get; set; }

    public DateTime EditDtm { get; set; }

    public string Cbecode { get; set; } = null!;

    public string Boid { get; set; } = null!;

    public long? HolderType { get; set; }

    public ulong SrNo { get; set; }

    public string? FirstName { get; set; }

    public string? MiddleName { get; set; }

    public string? LastName { get; set; }

    public string? Title { get; set; }

    public string? FatherHusName { get; set; }

    public string? Address { get; set; }

    public string? City { get; set; }

    public string? Cstate { get; set; }

    public string Country { get; set; } = null!;

    public string? PinCode { get; set; }

    public string PhoneIndicator1 { get; set; } = null!;

    public string? Phone1 { get; set; }

    public string PhoneIndicator2 { get; set; } = null!;

    public string Phone2 { get; set; } = null!;

    public string PhoneAddn { get; set; } = null!;

    public string Fax { get; set; } = null!;

    public string? Panname { get; set; }

    public string? Panno { get; set; }

    public byte[]? Itcircle { get; set; }

    public string? EmailId { get; set; }

    public byte[]? UserText1 { get; set; }

    public string PanexemptionCode { get; set; } = null!;

    public string PanverificationCode { get; set; } = null!;

    public long SignatureFileFlag { get; set; }

    public byte[]? Huid { get; set; }

    public long MinorIndicator { get; set; }

    public long IsGuardianOfNominee { get; set; }

    public byte[]? MaturityDate { get; set; }

    public DateOnly? BirthDate { get; set; }

    public string? Gender { get; set; }

    public DateOnly? SetupDate { get; set; }

    public long UccbatchNo { get; set; }

    public string? Paddress { get; set; }

    public string? Pcity { get; set; }

    public string? Pstate { get; set; }

    public string Pcountry { get; set; } = null!;

    public string? PpinCode { get; set; }

    public string Isdcode { get; set; } = null!;

    public string Stdcode { get; set; } = null!;

    public string PhoneList { get; set; } = null!;

    public string FaxList { get; set; } = null!;

    public string Pisdcode { get; set; } = null!;

    public string Pstdcode { get; set; } = null!;

    public string PphoneList { get; set; } = null!;

    public string PfaxList { get; set; } = null!;

    public long CstateCode { get; set; }

    public long CountryCode { get; set; }

    public long PstateCode { get; set; }

    public long PcountryCode { get; set; }

    public string CorrsAddrAsPermanent { get; set; } = null!;

    public byte[]? NameChangeReason { get; set; }

    public long IsFamilyEmail { get; set; }

    public long IsFamilyMobile { get; set; }

    public string PphoneIndicator1 { get; set; } = null!;

    public string? Pphone1 { get; set; }

    public string PphoneIndicator2 { get; set; } = null!;

    public string Pphone2 { get; set; } = null!;

    public string? MaritalStatusCode { get; set; }

    public string? District { get; set; }

    public string? AddressTypeFatca { get; set; }

    public string? Pdistrict { get; set; }

    public string? PaddressTypeFatca { get; set; }

    public string? MaidenPrefix { get; set; }

    public string? MaidenFirstName { get; set; }

    public string? MaidenMiddleName { get; set; }

    public string? MaidenLastName { get; set; }

    public string? MotherPrefix { get; set; }

    public string? MotherFirstName { get; set; }

    public string? MotherMiddleName { get; set; }

    public string? MotherLastName { get; set; }

    public string FlagFs { get; set; } = null!;

    public string? Fsprefix { get; set; }

    public string? FsfirstName { get; set; }

    public string? FsmiddleName { get; set; }

    public string? FslastName { get; set; }

    public decimal? NomineePercentage { get; set; }

    public string? NomineeResidual { get; set; }

    public string? NomineeRelationShip { get; set; }

    public string UdiverifyFlag { get; set; } = null!;

    public byte[]? UdinotUpdateReason { get; set; }

    public string SmartRegInd { get; set; } = null!;

    public byte[]? SmartCardNo { get; set; }

    public byte[]? SmartCardPin { get; set; }

    public byte[]? NmRegistrationNo { get; set; }

    public byte[]? CdslcitySeqNo { get; set; }

    public byte[]? CdslpcitySeqNo { get; set; }

    public string NationalityCode { get; set; } = null!;

    public string Nationality { get; set; } = null!;

    public DateOnly? GrossAnnualIncDate { get; set; }

    public string? GrossAnnualIncRange { get; set; }

    public string? GrossAnnualIncRangeCode { get; set; }

    public DateOnly? NetWorthDate { get; set; }

    public ulong? Networth { get; set; }

    public string? OccupationCode { get; set; }

    public string? Occupation { get; set; }

    public byte[]? AadhaarEnrollmentNo { get; set; }

    public string? CkycNo { get; set; }

    public long? Pepcode { get; set; }

    public string? GurdianMap { get; set; }

    public string? EducationCode { get; set; }

    public long Mdobdate { get; set; }

    public byte[]? MbirthDate { get; set; }

    public long RecordChanged { get; set; }

    public string Panex { get; set; } = null!;

    public long BoacOpenSource { get; set; }

    public long KrakycMode { get; set; }

    public byte[]? DateOfDeath { get; set; }

    public string? AccountName { get; set; }

    public byte[]? DeleteReasonCode { get; set; }

    public string AltEmailId { get; set; } = null!;
}
