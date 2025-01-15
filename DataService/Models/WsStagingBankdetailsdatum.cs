using System;
using System.Collections.Generic;

namespace DataService.Models;

public partial class WsStagingBankdetailsdatum
{
    public int Id { get; set; }

    public string? GroupId { get; set; }

    public string? OwnerId { get; set; }

    public string? ClientId { get; set; }

    public string? ClientCode { get; set; }

    public string? BankBranchName { get; set; }

    public string? BankAccountNumber { get; set; }

    public string? BankAccountType { get; set; }

    public string? BankMicr { get; set; }

    public string? BankIfsc { get; set; }

    public string? BankName { get; set; }

    public string? BankRtgs { get; set; }

    public bool? IsPrimary { get; set; }

    public bool? IsPoa { get; set; }

    public bool? Isactive { get; set; }

    public DateTime? Timestamp { get; set; }
}
