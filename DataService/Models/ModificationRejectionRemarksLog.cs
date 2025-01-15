using System;
using System.Collections.Generic;

namespace DataService.Models;

public partial class ModificationRejectionRemarksLog
{
    public int Id { get; set; }

    public int ModificationId { get; set; }

    public string? RejectionRemark { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }
}
