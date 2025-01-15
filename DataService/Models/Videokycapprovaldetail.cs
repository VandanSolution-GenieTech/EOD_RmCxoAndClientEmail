using System;
using System.Collections.Generic;

namespace DataService.Models;

public partial class Videokycapprovaldetail
{
    public int Id { get; set; }

    public int? VideoKycid { get; set; }

    public int? InvId { get; set; }

    public int? HolderRankId { get; set; }

    public string? ApprovalStatus { get; set; }

    public string? Comment { get; set; }

    public int? ApprovedBy { get; set; }

    public DateTime? ApprovedOn { get; set; }

    public bool? IsActive { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }
}
