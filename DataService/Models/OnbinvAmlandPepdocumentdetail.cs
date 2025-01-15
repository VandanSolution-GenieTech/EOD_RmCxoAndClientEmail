using System;
using System.Collections.Generic;

namespace DataService.Models;

public partial class OnbinvAmlandPepdocumentdetail
{
    public int Id { get; set; }

    public int InvId { get; set; }

    public bool? IsAml { get; set; }

    public bool? IsPep { get; set; }

    public string? DocumentFileName { get; set; }

    public string? DocumentFileExtension { get; set; }

    public string? DocumentFilePath { get; set; }

    public bool? IsActive { get; set; }

    public bool? IsDeleted { get; set; }

    public int CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public int ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }
}
