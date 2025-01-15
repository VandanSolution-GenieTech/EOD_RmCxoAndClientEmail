using System;
using System.Collections.Generic;

namespace DataService.Models;

public partial class Onbcurrentstatus
{
    public int? Id { get; set; }

    public int? StatusId { get; set; }

    public string? StatusName { get; set; }

    public string? CurrentStatus { get; set; }

    public int? Currentstatusid { get; set; }

    public string? Bucketting { get; set; }

    public string? StageGroup { get; set; }

    public bool? IsActive { get; set; }

    public bool? IsDeleted { get; set; }

    public int? CreatedBy { get; set; }

    public string? Createdon { get; set; }

    public int? ModifiedBy { get; set; }

    public string? ModifiedOn { get; set; }
}
