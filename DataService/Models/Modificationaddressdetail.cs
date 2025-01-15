using System;
using System.Collections.Generic;

namespace DataService.Models;

public partial class Modificationaddressdetail
{
    public int Id { get; set; }

    public int ModificationId { get; set; }

    public bool? IsModified { get; set; }

    public bool? AsPerKra { get; set; }

    public int? AddressDetailsId { get; set; }

    public int? AddressTypeId { get; set; }

    public int? AddressSubTypeId { get; set; }

    public string? Add1 { get; set; }

    public string? Add2 { get; set; }

    public int? CountryId { get; set; }

    public int? StateId { get; set; }

    public int? DistrictId { get; set; }

    public int? CityId { get; set; }

    public string? Pin { get; set; }

    public int? HolderRankId { get; set; }

    public bool? MarkedForDelete { get; set; }

    public DateTime? CreatedOn { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public bool? IsActive { get; set; }
}
