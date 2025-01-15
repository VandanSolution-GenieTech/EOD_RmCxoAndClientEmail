using System;
using System.Collections.Generic;

namespace DataService.Models;

public partial class VwIbeatsWpartyTrdNom
{
    public int InvId { get; set; }

    public string? FormNo { get; set; }

    public int? Products { get; set; }

    public long KycReqNo { get; set; }

    public string? AccountCode { get; set; }

    public long HolderType { get; set; }

    public ulong SrNo { get; set; }

    public string? FirstName { get; set; }

    public string? MiddleName { get; set; }

    public string? LastName { get; set; }

    public string? Title { get; set; }

    public string? FullAcName { get; set; }

    public string? NomineeRelationShip { get; set; }

    public string? Addr1 { get; set; }

    public string Addr2 { get; set; } = null!;

    public string Addr3 { get; set; } = null!;

    public string Addr4 { get; set; } = null!;

    public string? City { get; set; }

    public string? Cstate { get; set; }

    public string Country { get; set; } = null!;

    public string? PinCode { get; set; }

    public string CstateCode { get; set; } = null!;

    public string CountryCode { get; set; } = null!;

    public string District { get; set; } = null!;

    public string ToMobileList { get; set; } = null!;

    public string ToEmailList { get; set; } = null!;

    public string Panno { get; set; } = null!;

    public string AdharNo { get; set; } = null!;

    public string CkycNo { get; set; } = null!;

    public string? BirthDate { get; set; }

    public sbyte? MinorIndicator { get; set; }

    public string? GurdianMap { get; set; }

    public string Gender { get; set; } = null!;

    public DateTime SetupDate { get; set; }

    public string NomStatus { get; set; } = null!;

    public long EditId { get; set; }

    public DateTime EditDtm { get; set; }

    public long RecordChanged { get; set; }
}
