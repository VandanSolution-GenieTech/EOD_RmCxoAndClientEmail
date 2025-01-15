using System;
using System.Collections.Generic;

namespace DataService.Models;

public partial class Modificationdetail
{
    public int Id { get; set; }

    public int InvId { get; set; }

    public string? UccCode { get; set; }

    public int? StatusId { get; set; }

    public string? RejectionRemark { get; set; }

    public int? MakerId { get; set; }

    public int? CheckerId { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public bool? IsActive { get; set; }
}
