using System;
using System.Collections.Generic;

namespace DataService.Models;

public partial class Pincodemaster
{
    public int Id { get; set; }

    public string? Pincode { get; set; }

    public int? CityId { get; set; }

    public int? Districtid { get; set; }

    public int? StateId { get; set; }

    public string? CountryId { get; set; }

    public bool? IsActive { get; set; }

    public bool? IsDeleted { get; set; }

    public int? CreatedBy { get; set; }

    public string? CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public string? ModifiedOn { get; set; }
}
