using System;
using System.Collections.Generic;

namespace DataService.Models;

public partial class Bankbranchmaster
{
    public int Id { get; set; }

    public int? BankId { get; set; }

    public int? LocationIdBranchCode { get; set; }

    public string? Ifsccode { get; set; }

    public string? Micrcode { get; set; }

    public string? BranchName { get; set; }

    public string? Address { get; set; }

    public string? CityName { get; set; }

    public bool? IsActive { get; set; }

    public bool? IsDeleted { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }
}
