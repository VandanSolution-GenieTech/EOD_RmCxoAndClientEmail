using System;
using System.Collections.Generic;

namespace DataService.Models;

public partial class VwIbeatsWpartyContact
{
    public int InvId { get; set; }

    public string? AccountCode { get; set; }

    public int Products { get; set; }

    public ulong ContactType { get; set; }

    public string? PersonName { get; set; }

    public string? Designation { get; set; }

    public string Panno { get; set; } = null!;

    public string? Addr { get; set; }

    public string? PhoneList { get; set; }

    public string? EmailList { get; set; }

    public string? BirthDate { get; set; }

    public string? Gender { get; set; }

    public int AuthSignatory { get; set; }

    public int EditId { get; set; }

    public DateTime EditDtm { get; set; }

    public int KycReqNo { get; set; }

    public string? Din { get; set; }

    public string? DirectorPan { get; set; }

    public int ForeignerFlag { get; set; }

    public string RelationWithKarta { get; set; } = null!;

    public string PassportNo { get; set; } = null!;

    public int PanexemptFlag { get; set; }

    public int PanexemptCode { get; set; }

    public string? ContactPersonDesignationCode { get; set; }

    public string Uid { get; set; } = null!;

    public string? Addr1 { get; set; }

    public string Addr2 { get; set; } = null!;

    public string Addr3 { get; set; } = null!;

    public string? City { get; set; }

    public string? Cstate { get; set; }

    public string Country { get; set; } = null!;

    public string? PinCode { get; set; }

    public int CstateCode { get; set; }

    public int CountryCode { get; set; }

    public int KycReqStatus { get; set; }

    public int Pepcode { get; set; }

    public string AadhaarEnrollmentNo { get; set; } = null!;

    public string AuthOrderFlag { get; set; } = null!;

    public int IgnoreUcc { get; set; }

    public string? HufdateofFormation { get; set; }

    public int HufancestralFlag { get; set; }

    public string? FatherName { get; set; }

    public string NameChangeKartaNsdl { get; set; } = null!;

    public string KartaChangeReasonNsdl { get; set; } = null!;

    public string HufsetupNsdl { get; set; } = null!;

    public string AppointasKarta { get; set; } = null!;

    public string Vidno { get; set; } = null!;

    public string Remarks { get; set; } = null!;

    public string UdiverifyFlag { get; set; } = null!;

    public string Addr4 { get; set; } = null!;

    public int AuthTrader { get; set; }
}
