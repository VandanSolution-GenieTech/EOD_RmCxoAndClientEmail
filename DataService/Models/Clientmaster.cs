using System;
using System.Collections.Generic;

namespace DataService.Models;

public partial class Clientmaster
{
    public int Id { get; set; }

    public int? SalutationId { get; set; }

    public string? FirstName { get; set; }

    public string? MiddleName { get; set; }

    public string? LastName { get; set; }

    public string? Pan { get; set; }

    public DateTime Dob { get; set; }

    public int ClientTypeId { get; set; }

    public bool? IsActive { get; set; }

    public bool? IsDeleted { get; set; }

    public int CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public int ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }
}
