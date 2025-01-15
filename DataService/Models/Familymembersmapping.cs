using System;
using System.Collections.Generic;

namespace DataService.Models;

public partial class Familymembersmapping
{
    public int Id { get; set; }

    public int FamilyId { get; set; }

    public string Name { get; set; } = null!;

    public string Pan { get; set; } = null!;

    public int? RelationshipWithHead { get; set; }

    public string? UccCode { get; set; }

    public string? Email { get; set; }

    public string? Mobile { get; set; }

    public bool IsActive { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }
}
