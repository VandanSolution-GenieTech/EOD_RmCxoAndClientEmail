using System;
using System.Collections.Generic;

namespace DataService.Models;

public partial class Omsdashboardvisibility
{
    public int Id { get; set; }

    public int Roleid { get; set; }

    public bool? Createorders { get; set; }

    public bool? Cxodashboard { get; set; }

    public bool? Bonddashboard { get; set; }

    public bool? Opsdashboard { get; set; }

    public bool? Dealerdashboard { get; set; }

    public bool? FMdashboard { get; set; }

    public bool? Pmsopsdashboard { get; set; }

    public bool? Bondops { get; set; }

    public bool? Reports { get; set; }

    public bool? Overallashboard { get; set; }

    public bool? Isactive { get; set; }

    public bool? Isdeleted { get; set; }

    public bool? Opsaifinternal { get; set; }

    public bool? Pmssaifinternal { get; set; }

    public string? Rolename { get; set; }
}
