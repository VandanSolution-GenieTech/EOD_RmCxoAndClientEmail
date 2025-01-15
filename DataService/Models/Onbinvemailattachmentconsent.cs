using System;
using System.Collections.Generic;

namespace DataService.Models;

public partial class Onbinvemailattachmentconsent
{
    public int Id { get; set; }

    public int? InvId { get; set; }

    public bool? PlatformLoginConsent { get; set; }

    public string? PlatformUserId { get; set; }

    public string? PlatformLoginPassword { get; set; }

    public bool? IsActive { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }
}
