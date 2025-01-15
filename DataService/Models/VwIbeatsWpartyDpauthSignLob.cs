using System;
using System.Collections.Generic;

namespace DataService.Models;

public partial class VwIbeatsWpartyDpauthSignLob
{
    public int InvId { get; set; }

    public int KycReqNo { get; set; }

    public string? FormNo { get; set; }

    public string? AccountCode { get; set; }

    public int Products { get; set; }

    public ulong SignSrno { get; set; }

    public string? PersonName { get; set; }

    public string? Designation { get; set; }

    public string? Addr { get; set; }

    public string PhoneList { get; set; } = null!;

    public string EmailList { get; set; } = null!;

    public string? AttachFileName { get; set; }

    public int EditId { get; set; }

    public DateTime EditDtm { get; set; }

    public long? HolderIndicator { get; set; }

    public int KycReqStatus { get; set; }

    public byte[]? Boid { get; set; }

    public string Remarks1 { get; set; } = null!;

    public int FileSize { get; set; }

    public int Cbecode { get; set; }

    public string OldFileName { get; set; } = null!;

    public string NewFileName { get; set; } = null!;

    public int SignTrxType { get; set; }

    public int AuthFlag { get; set; }
}
