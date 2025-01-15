using System;
using System.Collections.Generic;

namespace DataService.Models;

public partial class Onbinvhufcoparcener
{
    public int Id { get; set; }

    public int InvId { get; set; }

    public string? Pan { get; set; }

    public string? Name { get; set; }

    public DateOnly? Dob { get; set; }

    public int? Relationship { get; set; }

    public string? RelationshipOther { get; set; }

    public int? Gender { get; set; }

    public bool? IsActive { get; set; }

    public DateTime? CreatedOn { get; set; }

    public DateTime? ModifiedOn { get; set; }
}
