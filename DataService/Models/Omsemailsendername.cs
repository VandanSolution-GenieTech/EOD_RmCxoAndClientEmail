using System;
using System.Collections.Generic;

namespace DataService.Models;

public partial class Omsemailsendername
{
    public int Id { get; set; }

    public int? Entityid { get; set; }

    public int? Subproductid { get; set; }

    public string? Fromaddress { get; set; }

    public bool? Isactive { get; set; }
}
