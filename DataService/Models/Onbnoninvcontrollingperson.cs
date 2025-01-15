using System;
using System.Collections.Generic;

namespace DataService.Models;

public partial class Onbnoninvcontrollingperson
{
    public int Id { get; set; }

    public int InvId { get; set; }

    public int HolderRankId { get; set; }

    public string? HolderName { get; set; }

    public int? SerialNo { get; set; }

    public string? Name { get; set; }

    public string? MobileNumber { get; set; }

    public string? MotherName { get; set; }

    public string? Email { get; set; }

    public int? ControllingPersonCode { get; set; }

    public int? TaxCountry { get; set; }

    public string? TaxIdentificationType { get; set; }

    public string? TaxPayerRefId { get; set; }

    public string? Address { get; set; }

    public bool? ExtraField { get; set; }

    public string? CustomerId { get; set; }

    public int? Gender { get; set; }

    public int? BirthCountry { get; set; }

    public string? BirthCity { get; set; }

    public int? Nationality { get; set; }

    public string? DateOfBrith { get; set; }

    public int? Occupation { get; set; }

    public string? OtherOcuupation { get; set; }

    public string? Pan { get; set; }

    public int? AddressType { get; set; }

    public string? AadharNumber { get; set; }

    public string? IdentificationType { get; set; }

    public string? IdentificationNumber { get; set; }

    public string? FatherName { get; set; }

    public string? SpouseName { get; set; }

    public bool? IsActive { get; set; }

    public bool? IsDeleted { get; set; }

    public int CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public int ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }
}
