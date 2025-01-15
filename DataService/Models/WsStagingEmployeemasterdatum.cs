using System;
using System.Collections.Generic;

namespace DataService.Models;

public partial class WsStagingEmployeemasterdatum
{
    public int Id { get; set; }

    public string? Code { get; set; }

    public string? Email { get; set; }

    public string? Mobile { get; set; }

    public string? Name { get; set; }

    public string? Lob { get; set; }

    public string? Designation { get; set; }

    public string? Department { get; set; }

    public string? Euin { get; set; }

    public string? ReportingManagerCode { get; set; }

    public bool? IsActive { get; set; }

    public DateTime? Createdon { get; set; }
}
