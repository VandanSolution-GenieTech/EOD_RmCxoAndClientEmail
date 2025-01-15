using System;
using System.Collections.Generic;

namespace DataService.Models;

public partial class Onbinvestorbankdetailsapprovallog
{
    public int Id { get; set; }

    public int? BankDetailsId { get; set; }

    public int? BranchId { get; set; }

    public string? AccountNo { get; set; }

    public decimal? NameMatchScore { get; set; }

    public string? NameMatch { get; set; }

    public string? NameAsPerBank { get; set; }

    public string? Comment { get; set; }

    public string? ApprovalStatus { get; set; }

    public int? ApprovedBy { get; set; }

    public DateTime? ApprovedOn { get; set; }
}
