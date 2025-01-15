using System;
using System.Collections.Generic;

namespace DataService.Models;

public partial class Onbinvestordocumentapprovallog
{
    public int Id { get; set; }

    public int? DocumentDetailsId { get; set; }

    public string? ApprovalStatus { get; set; }

    public string? Comment { get; set; }

    public int? ApprovedBy { get; set; }

    public DateTime? ApprovedOn { get; set; }
}
