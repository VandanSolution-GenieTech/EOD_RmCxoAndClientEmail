using System;
using System.Collections.Generic;

namespace DataService.Models;

public partial class Countrymaster
{
    public int Id { get; set; }

    public string? CountryName { get; set; }

    public string? CountryCode { get; set; }

    public int? IsNriallow { get; set; }

    public int? IsLandbordering { get; set; }

    public int? IsFatf { get; set; }

    public int? ProductIds { get; set; }

    public bool? IsActive { get; set; }

    public bool? IsDeleted { get; set; }

    public int CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public int ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }
}
