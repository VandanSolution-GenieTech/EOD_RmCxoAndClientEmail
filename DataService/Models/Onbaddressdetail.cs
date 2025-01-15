using System;
using System.Collections.Generic;

namespace DataService.Models;

public partial class Onbaddressdetail
{
    public int Id { get; set; }

    public int InvId { get; set; }

    public int? AddressProof { get; set; }

    public int AddressTypeId { get; set; }

    public int? AddressSubTypeId { get; set; }

    public string? Add1 { get; set; }

    public string? Add2 { get; set; }

    public int CountryId { get; set; }

    public int StateId { get; set; }

    public int DistrictId { get; set; }

    public int? CityId { get; set; }

    public string? Pin { get; set; }

    public int HolderRankId { get; set; }

    public bool? IsGuardianAddress { get; set; }

    public int? Poaid { get; set; }

    public string? PoaotherName { get; set; }

    public bool? IsActive { get; set; }

    public bool? IsDeleted { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }
}
