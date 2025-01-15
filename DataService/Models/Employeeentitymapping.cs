using System;
using System.Collections.Generic;

namespace DataService.Models;

public partial class Employeeentitymapping
{
    public int Id { get; set; }

    public int EmpId { get; set; }

    public int EntityId { get; set; }

    public bool? IsDefault { get; set; }

    public bool? IsActive { get; set; }

    public bool? IsDeleted { get; set; }

    public int? Createdby { get; set; }

    public DateTime? CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }
}
