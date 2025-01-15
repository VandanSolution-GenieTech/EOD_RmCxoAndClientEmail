using System;
using System.Collections.Generic;

namespace DataService.Models;

public partial class Modificationemaildetail
{
    public int Id { get; set; }

    public int ModificationId { get; set; }

    public bool? IsModified { get; set; }

    public string? OldValue { get; set; }

    public string? NewValue { get; set; }

    public string? OptionFamily { get; set; }

    public bool? EmailVerificationFlag { get; set; }

    public DateTime? CreatedOn { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public bool? IsActive { get; set; }
}
