using System;
using System.Collections.Generic;

namespace DataService.Models;

public partial class EmployeeDistributorbankermapping
{
    public int Id { get; set; }

    public int ExternalEmpId { get; set; }

    public int ExternalBankerId { get; set; }

    public bool? IsDefault { get; set; }

    public bool? IsActive { get; set; }

    public bool? IsDeleted { get; set; }

    public int? Createdby { get; set; }

    public DateTime? CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }
}
