using System;
using System.Collections.Generic;

namespace DataService.Models;

public partial class Onbholderdetail
{
    public int Id { get; set; }

    public int InvId { get; set; }

    public int? SalutationId { get; set; }

    public string? FirstName { get; set; }

    public string? MiddleName { get; set; }

    public string? LastName { get; set; }

    public int? MaritalstatusId { get; set; }

    public int? GenderId { get; set; }

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

    public string? Name { get; set; }

    public string? Cin { get; set; }

    public string? Gstin { get; set; }

    public int? PlaceofCorporation { get; set; }

    public int? CountryOfIncorporation { get; set; }

    public string? RegisterNumber { get; set; }

    public string? DateofCommencementBusiness { get; set; }

    public int? Status { get; set; }

    public bool? IsNpo { get; set; }

    public string? DarpanRegNo { get; set; }

    public string? OtherStatus { get; set; }

    public int? TypeofSubStatus { get; set; }

    public string? TypeAccountOtherStatus { get; set; }

    public int? ProofOfIdentity { get; set; }

    public int? RelationShipWithPrimaryHolder { get; set; }

    public string? Ckynumber { get; set; }

    public string? Pan { get; set; }

    public string? Dob { get; set; }

    public string? Aadhar { get; set; }

    public string? Mobile { get; set; }

    public string? Email { get; set; }

    public string? SecondaryMobile { get; set; }

    public string? SecondaryEmail { get; set; }

    public string? OptionFamily { get; set; }

    public bool? IsDuplicateContactDetailsDeclarationGiven { get; set; }

    public int? DuplicateContactRelationshipId { get; set; }

    public int? CitizenshipId { get; set; }

    public int? ResidentialStatusId { get; set; }

    public int? RelatedPersonType { get; set; }

    public string? Din { get; set; }

    public string? OtherRelatedType { get; set; }

    public int? ControllingPersonTypeCode { get; set; }

    public bool? IsAuthorisedSignatory { get; set; }

    public bool? IsControlledPerson { get; set; }

    public int? OccupationTypeId { get; set; }

    public string? OccupationTypeOtherValue { get; set; }

    public int? DesignationId { get; set; }

    public string? DesignationTypeOtherValue { get; set; }

    public string? TrustandSociety { get; set; }

    public int? Education { get; set; }

    public int? SubEducation { get; set; }

    public string? SubEducationOtherValue { get; set; }

    public int? NatureOfBusiness { get; set; }

    public string? NatureOfBusinessOtherValue { get; set; }

    public int? NumberOfYearsInBusiness { get; set; }

    public long? AnnualTurnOver { get; set; }

    public int? SourceOfIncomeId { get; set; }

    public string? NonInvSourceIncome { get; set; }

    public int? IncomeId { get; set; }

    public int? NonInvIncome { get; set; }

    public string? DpHoldingDate { get; set; }

    public string? DpHoldingValue { get; set; }

    public string? NetWorth { get; set; }

    public string? NetworstAsOnDate { get; set; }

    public string? EducationalQualification { get; set; }

    public string? IsNeoemployee { get; set; }

    public string? EmployeeLobname { get; set; }

    public string? DependentonEmployeeName { get; set; }

    public string? DependentonEmployeeLobname { get; set; }

    public string? NetWorthInWord { get; set; }

    public string? NatureofOrganisation { get; set; }

    public decimal? MonthlyIncome { get; set; }

    public decimal? NetAnnualIncome { get; set; }

    public string? SourceOfFund { get; set; }

    public int? SourceOfFundId { get; set; }

    public string? TypeOfIndustry { get; set; }

    public string? IndustryCode { get; set; }

    public string? AnnualTurnOverNumber { get; set; }

    public int? InvestmentTradingExperience { get; set; }

    public string? SpouseName { get; set; }

    public int? BirthCountryId { get; set; }

    public int? BirthCityId { get; set; }

    public string? BirthOtherCityName { get; set; }

    public string? EsignPreferredType { get; set; }

    public string? IsWhatsappConsent { get; set; }

    public int? CountryOfResidence { get; set; }

    public string? NetworthNri { get; set; }

    public int? DpTypeId { get; set; }

    public string? DpId { get; set; }

    public string? DpName { get; set; }

    public string? KraStatusNumber { get; set; }

    public string? NatureofOrganisationOther { get; set; }

    public string? SourceOfFundOther { get; set; }

    public string? Ipvby { get; set; }

    public int? PoliticallyExposedTypeId { get; set; }

    public int? RelatedPoliticallyExposedTypeId { get; set; }

    public bool? IsOnlyTaxResidentOfIndia { get; set; }

    public bool? IsTaxResidentOtherThanIndia { get; set; }

    public bool? IsCorrespondanceAddressDifferentFromPermenanat { get; set; }

    public bool? IsGuardianCorrespondanceAddressDifferentFromPermenanat { get; set; }

    public string? GuardianName { get; set; }

    public string? GuardianPan { get; set; }

    public string? GuardianMobile { get; set; }

    public string? GuardianEmail { get; set; }

    public string? GuardianAddress { get; set; }

    public int? GuardianRelationShipWithApplicant { get; set; }

    public bool? IsLiasonOfficerAvailable { get; set; }

    public string? LiasonOfficerName1 { get; set; }

    public string? LiasonOfficerEmail1 { get; set; }

    public string? LiasonOfficerMobile1 { get; set; }

    public string? LiasonOfficerName2 { get; set; }

    public string? LiasonOfficerEmail2 { get; set; }

    public string? LiasonOfficerMobile2 { get; set; }

    public string? LiasonOfficerName3 { get; set; }

    public string? LiasonOfficerEmail3 { get; set; }

    public string? LiasonOfficerMobile3 { get; set; }

    public int? HolderRankId { get; set; }

    public bool? IsActive { get; set; }

    public bool? IsDeleted { get; set; }

    public int CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public int ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }
}
