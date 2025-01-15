using System;
using System.Collections.Generic;

namespace DataService.Models;

public partial class VwIbeatsWpartyCbe
{
    public int InvId { get; set; }

    public int Products { get; set; }

    public string? AccountCode { get; set; }

    public string Cbecode { get; set; } = null!;

    public string ExcClientId { get; set; } = null!;

    public string TermId { get; set; } = null!;

    public string FrontMapInId { get; set; } = null!;

    public string DealerAcCode { get; set; } = null!;

    public string EmailList { get; set; } = null!;

    public string Bsestatus { get; set; } = null!;

    public string ClientCategory { get; set; } = null!;

    public string AgreementDate { get; set; } = null!;

    public string StampDate { get; set; } = null!;

    public string SigningDate { get; set; } = null!;

    public byte[]? ActiveDate { get; set; }

    public string DeactiveDate { get; set; } = null!;

    public string FirstTradeDate { get; set; } = null!;

    public int ExUploadStatus { get; set; }

    public byte[]? ExSentDate { get; set; }

    public string ExConfirmDate { get; set; } = null!;

    public int MyBatchNo { get; set; }

    public int ActivationByUserId { get; set; }

    public int KycReqNo { get; set; }

    public int EditId { get; set; }

    public DateTime EditDtm { get; set; }

    public int KycReqStatus { get; set; }

    public int MyLineNo { get; set; }

    public int KycFormVersion { get; set; }

    public int ESignKyc { get; set; }

    public string PhyDocRecvdDate { get; set; } = null!;

    public int DormantType { get; set; }

    public string? FormNo { get; set; }

    public int Mfssmode { get; set; }
}
