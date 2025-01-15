using System;
using System.Collections.Generic;

namespace DataService.Models;

public partial class Familymaster
{
    public int Id { get; set; }

    public string? FamilyName { get; set; }

    public string? FamilyCode { get; set; }

    public string? FamilyShortName { get; set; }

    public bool? IsSignedUp { get; set; }

    public bool? IsActive { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }
}
