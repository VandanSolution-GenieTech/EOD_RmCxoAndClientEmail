using System;
using System.Collections.Generic;

namespace DataService.Models;

public partial class Onbinvdocumentdetail
{
    public int Id { get; set; }

    public int InvId { get; set; }

    public int? HolderRankId { get; set; }

    public int? NomineeRanKid { get; set; }

    public int? DocumentTypeId { get; set; }

    public string? DocumentExpiryDate { get; set; }

    public string? DocumentFileName { get; set; }

    public string? DocumentFileExtension { get; set; }

    public string? DocumentFilePath { get; set; }

    public int? PagesCount { get; set; }

    public bool? IsActive { get; set; }

    public bool? IsDeleted { get; set; }

    public int CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public string? ApprovalStatus { get; set; }

    public string? Comment { get; set; }

    public int? ApprovedBy { get; set; }

    public DateTime? ApprovedOn { get; set; }

    public int ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }
}
