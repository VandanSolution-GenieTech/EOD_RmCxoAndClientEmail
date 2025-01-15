using System;
using System.Collections.Generic;

namespace DataService.Models;

public partial class Onbinvfamilymapping
{
    public int Id { get; set; }

    public int? InvId { get; set; }

    public bool? FamilyMappingNeeded { get; set; }

    public int? FamilyId { get; set; }

    public bool? IsActive { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }
}
