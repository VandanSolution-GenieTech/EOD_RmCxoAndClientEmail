using System;
using System.Collections.Generic;

namespace DataService.Models;

public partial class Onbnoninvcontactdetail
{
    public int Id { get; set; }

    public int InvId { get; set; }

    public int HolderRankId { get; set; }

    public int ContactRankId { get; set; }

    public string? KeyContactPerson { get; set; }

    public int? Designation { get; set; }

    public string? OtherDesignation { get; set; }

    public string? MobileNo { get; set; }

    public string? EmailId { get; set; }

    public string? Remark { get; set; }

    public bool? AuthorisedRepresentative { get; set; }

    public bool? IsActive { get; set; }

    public bool? IsDeleted { get; set; }

    public int CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public int ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }
}
