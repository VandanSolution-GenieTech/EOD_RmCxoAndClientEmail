using System;
using System.Collections.Generic;

namespace DataService.Models;

public partial class OmsNonBusinessDayHolidayMaster
{
    public string? SchemeCode { get; set; }

    public string? SchemeName { get; set; }

    public DateTime? Date { get; set; }

    public bool? Isactive { get; set; }

    public int? Createdby { get; set; }

    public DateTime? Createdon { get; set; }

    public int Id { get; set; }
}
