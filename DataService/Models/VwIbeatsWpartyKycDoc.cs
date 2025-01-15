using System;
using System.Collections.Generic;

namespace DataService.Models;

public partial class VwIbeatsWpartyKycDoc
{
    public int InvId { get; set; }

    public string? FormNo { get; set; }

    public string? AccountCode { get; set; }

    public int Products { get; set; }

    public int EditId { get; set; }

    public DateTime EditDtm { get; set; }

    public int KycDocId { get; set; }

    public ulong SrNo { get; set; }

    public string? DocNo { get; set; }

    public string DocPlace { get; set; } = null!;

    public byte[]? DocIssueDate { get; set; }

    public byte[]? DocExpiryDate { get; set; }

    public int NoOfCopies { get; set; }

    public string Remarks { get; set; } = null!;

    public bool AttachStatus { get; set; }

    public int VerifyStatus { get; set; }

    public int KycReqNo { get; set; }

    public int KycReqStatus { get; set; }

    public string ImageFlag { get; set; } = null!;

    public string? ImageName { get; set; }

    public string DocIdList { get; set; } = null!;

    public string? AddrTypeList { get; set; }

    public byte[]? DocStartDate { get; set; }

    public byte[]? DocEndDate { get; set; }

    public int? HolderType { get; set; }

    public int Becode { get; set; }

    public string? OrgImageName { get; set; }

    public string? PanNo { get; set; }

    public string? ImagePath { get; set; }

    public int IsSignature { get; set; }

    public int? MaxFileSize { get; set; }
}
