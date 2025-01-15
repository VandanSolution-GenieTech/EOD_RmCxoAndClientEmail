using System;
using System.Collections.Generic;

namespace DataService.Models;

public partial class Bankermaster
{
    public int Id { get; set; }

    public int? EmpId { get; set; }

    public int Cpid { get; set; }

    public string? Salutation { get; set; }

    public string? Name { get; set; }

    public string? ShortName { get; set; }

    public string? Pan { get; set; }

    public int? Entityid { get; set; }

    public int? SubLobId { get; set; }

    public string? FaxNo { get; set; }

    public string? EmailId { get; set; }

    public string? MisemailId { get; set; }

    public string? SoaemailId { get; set; }

    public string? InvoiceEmailId { get; set; }

    public string? Mobile1 { get; set; }

    public string? Mobile2 { get; set; }

    public string? OfficeNo { get; set; }

    public string? IfotherDistributorType { get; set; }

    public string? DateofIncorporation { get; set; }

    public int? CategoryId { get; set; }

    public string? AcquiringRmname { get; set; }

    public int? AcquiringRmid { get; set; }

    public int? ServicingRmid { get; set; }

    public string? FacebookId { get; set; }

    public string? TwitterId { get; set; }

    public string? LinkedinId { get; set; }

    public string? InstagramId { get; set; }

    public string? MultiplePointPresence { get; set; }

    public string? AumraisedOver100IncludingHighNetworth { get; set; }

    public string? CommissionReceivedover1CrPerAnnum { get; set; }

    public string? CommissionReceivedOver50lacsFromSingleMf { get; set; }

    public string? Declaration { get; set; }

    public string? EmpanelmentDate { get; set; }

    public string? IndustryClassificationId { get; set; }

    public string? PriorityId { get; set; }

    public string? LevelId { get; set; }

    public string? KeyRelationship { get; set; }

    public string? IsInternal { get; set; }

    public string? AllPms { get; set; }

    public string? AllAif { get; set; }

    public string? AllMf { get; set; }

    public string? AmfiregistartionNo { get; set; }

    public string? AmfipassedOnDate { get; set; }

    public string? AmfivalidUpto { get; set; }

    public string? AmfibusinessModelId { get; set; }

    public string? SellingExperience { get; set; }

    public string? IfOtherSellingExperience { get; set; }

    public string? IfEquityCompanyName { get; set; }

    public string? IfEquityTotalExperience { get; set; }

    public string? IfInsuranceCompanyName { get; set; }

    public string? ClientTypeId { get; set; }

    public string? Aumequity { get; set; }

    public string? Aumdebt { get; set; }

    public string? Aumliquid { get; set; }

    public string? Aumpms { get; set; }

    public string? Aumaif { get; set; }

    public string? ClientProfileld { get; set; }

    public int? DistributionId { get; set; }

    public string? ModelId { get; set; }

    public string? FlavourForElss { get; set; }

    public string? AnyAwardsAchievements { get; set; }

    public string? NomineeSalutation { get; set; }

    public string? NomineeFirstName { get; set; }

    public string? NomineeMiddleName { get; set; }

    public string? NomineeLastName { get; set; }

    public string? NomineeDob { get; set; }

    public string? NomineeRelationshipId { get; set; }

    public string? GuardianSalutation { get; set; }

    public string? NomineeGuardianFirstName { get; set; }

    public string? NomineeGuardianMiddleName { get; set; }

    public string? NomineeGuardianLastName { get; set; }

    public string? NomineeAddressLine1 { get; set; }

    public string? NomineeAddressLine2 { get; set; }

    public string? NomineeAddressLine3 { get; set; }

    public string? NomineeCityId { get; set; }

    public string? NomineestateId { get; set; }

    public string? NomineePin { get; set; }

    public string? GroupId { get; set; }

    public string? Gstno { get; set; }

    public string? Domain { get; set; }

    public string? Product { get; set; }

    public string? DistWhatsappConsent { get; set; }

    public string? ClientwhatsappConsent { get; set; }

    public string? IsPreOnBoardingCallRequired { get; set; }

    public string? IsSystematicInvestmentAllowed { get; set; }

    public bool? IsActive { get; set; }

    public bool? IsDeleted { get; set; }

    public int? CreatedBy { get; set; }

    public int? CreatedOn { get; set; }

    public int? ModifiedByBy { get; set; }

    public int? ModifiedOn { get; set; }
}
