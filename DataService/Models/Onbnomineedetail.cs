using System;
using System.Collections.Generic;

namespace DataService.Models;

public partial class Onbnomineedetail
{
    public int Id { get; set; }

    public int? InvId { get; set; }

    public int? SalutationId { get; set; }

    public string? FirstName { get; set; }

    public string? MiddleName { get; set; }

    public string? LastName { get; set; }

    public int? MaidenSalutationId { get; set; }

    public string? MaidenFirstName { get; set; }

    public string? MaidenMiddleName { get; set; }

    public string? MaidenLastName { get; set; }

    public int? FatherSalutationId { get; set; }

    public string? FatherFirstName { get; set; }

    public string? FatherMiddleName { get; set; }

    public string? FatherLastName { get; set; }

    public int? MotherSalutationid { get; set; }

    public string? MotherFirstName { get; set; }

    public string? MotherMiddleName { get; set; }

    public string? MotherLastName { get; set; }

    public bool? IsNomineeAddressSameAsApplicant { get; set; }

    public int AddressType { get; set; }

    public string? Address { get; set; }

    public int? CountryId { get; set; }

    public int? StateId { get; set; }

    public int? DistrictId { get; set; }

    public int? CityId { get; set; }

    public string? Pin { get; set; }

    public string? TelNo { get; set; }

    public string? FaxNo { get; set; }

    public int? DocumentTypeId { get; set; }

    public string? OtherDocumentName { get; set; }

    public string? DocumentIdentificationNumber { get; set; }

    public DateTime? DocumentExpiryDate { get; set; }

    public string? EmailId { get; set; }

    public string? Mobile { get; set; }

    public string? DateofBirth { get; set; }

    public bool? IsMinor { get; set; }

    public int? RelationshipWithApplicantId { get; set; }

    public string? RelationshipWithApplicant { get; set; }

    public string? GaurdianName { get; set; }

    public bool? IsGaurdianAddressSameAsNominee { get; set; }

    public int? GaurdianAddressType { get; set; }

    public string? GaurdianAddress { get; set; }

    public int? GaurdianCityId { get; set; }

    public int? GaurdianDistrictId { get; set; }

    public int? GaurdianStateId { get; set; }

    public string? Gaurdianpincode { get; set; }

    public string? GaurdianMobileNumber { get; set; }

    public string? GaurdianEmail { get; set; }

    public int? GaurdianDocumentTypeId { get; set; }

    public string? GaurdianDocumentIdentificationNumber { get; set; }

    public DateTime? GaurdianDocumentExpiryDate { get; set; }

    public int? RelationshipOfGuardianWithNomineeId { get; set; }

    public string? Dpid { get; set; }

    public decimal AllocationOfSecuritiesFunds { get; set; }

    public bool? ToBeConsideredForBankPoa { get; set; }

    public string? ResidualSecurities { get; set; }

    public int? NomineeRanKid { get; set; }

    public bool? IsActive { get; set; }

    public bool? IsDeleted { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }
}
