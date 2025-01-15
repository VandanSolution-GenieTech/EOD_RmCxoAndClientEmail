using System;
using System.Collections.Generic;

namespace DataService.Models;

public partial class Familyheadmappinglog
{
    public int Id { get; set; }

    public int? MappingId { get; set; }

    public int FamilyId { get; set; }

    public string Name { get; set; } = null!;

    public string Pan { get; set; } = null!;

    public string? Email { get; set; }

    public string? Mobile { get; set; }

    public bool IsActive { get; set; }

    public int UpdatedBy { get; set; }

    public DateTime UpdatedOn { get; set; }
}
