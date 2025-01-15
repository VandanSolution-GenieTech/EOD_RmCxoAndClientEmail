using System;
using System.Collections.Generic;

namespace DataService.Models;

public partial class Bankmaster
{
    public int Id { get; set; }

    public int? Cpid { get; set; }

    public string? BankName { get; set; }

    public bool? IsActive { get; set; }

    public bool? IsDeleted { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }
}
