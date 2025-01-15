using System;
using System.Collections.Generic;

namespace DataService.Models;

public partial class VwIbeatsWpartySubBank
{
    public int InvId { get; set; }

    public string? FormNo { get; set; }

    public int Products { get; set; }

    public string? AccountCode { get; set; }

    public string? SubAccountCode { get; set; }

    public string? BankAccountNo { get; set; }

    public string? BankAccountType { get; set; }

    public string? BankName { get; set; }

    public string? BankBranch { get; set; }

    public string? BankMicrcode { get; set; }

    public string? BankIfsccode { get; set; }

    public string BankId { get; set; } = null!;

    public string? BankLocation { get; set; }

    public int BankPoasw { get; set; }

    public string BankPoano { get; set; } = null!;

    public byte[]? BankPoadate { get; set; }

    public int PayInPriority { get; set; }

    public int PayOutDefault { get; set; }

    public int Pocbecode { get; set; }

    public int PurposeType { get; set; }

    public int ActiveStatus { get; set; }

    public int RcvdProof { get; set; }

    public DateTime EntryDate { get; set; }

    public int EditId { get; set; }

    public DateTime EditDtm { get; set; }

    public int KycReqNo { get; set; }

    public string? BankType { get; set; }

    public int Ecs { get; set; }

    public int KycReqStatus { get; set; }

    public int PayOutDefaultCx { get; set; }

    public byte[]? PayOutDefaultMf { get; set; }

    public int Mfcbecode { get; set; }

    public string NachUmrn { get; set; } = null!;

    public byte[]? NachLimitAmt { get; set; }

    public byte[]? NachStartDate { get; set; }

    public byte[]? NachEndDate { get; set; }

    public byte[]? NachFreq { get; set; }

    public byte[]? NachDrType { get; set; }

    public string BankClassification { get; set; } = null!;

    public int OnlyDp { get; set; }

    public int DirectDebit { get; set; }

    public int Pissw { get; set; }

    public int IsDeleted { get; set; }
}
