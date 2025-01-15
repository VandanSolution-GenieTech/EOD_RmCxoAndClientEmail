using System;
using System.Collections.Generic;

namespace DataService.Models;

public partial class Fundmaster
{
    public int Id { get; set; }

    public int? ProductTypeId { get; set; }

    public int? ProductCategoryId { get; set; }

    public int? IndustryId { get; set; }

    public int? EntityId { get; set; }

    public int? Camsid { get; set; }

    public string? ProductName { get; set; }

    public string? ProductShortName { get; set; }

    public string? ProductLaunchDate { get; set; }

    public string? IsOpenEnded { get; set; }

    public string? CurrencyId { get; set; }

    public string? InvestmentObjective { get; set; }

    public string? Benchmark { get; set; }

    public string? InvestmentStrategy { get; set; }

    public string? RecommendedTenureMinimumInvestment { get; set; }

    public string? MinimumInvestmentDenomination { get; set; }

    public string? UnderlyingAssetClasses { get; set; }

    public string? EligibleInvestors { get; set; }

    public string? SponsorName { get; set; }

    public string? FrequencyOfReportingId { get; set; }

    public string? SubscriptionsIdRedemptionsId { get; set; }

    public string? Custodian { get; set; }

    public string? Farta { get; set; }

    public string? Рсм { get; set; }

    public string? PaymentAggregatorListedOnExchange { get; set; }

    public string? Regulator { get; set; }

    public string? CapitalContributionLockInPeriodInDays { get; set; }

    public string? PayoutTimeline { get; set; }

    public string? ProductStatus { get; set; }

    public string? CatchUp { get; set; }

    public string? MaturityDate { get; set; }

    public string? AmortizationMaturityDate { get; set; }

    public bool? IsActive { get; set; }

    public bool? IsDeleted { get; set; }

    public string? IsAumpresent { get; set; }

    public string? CreatedBy { get; set; }

    public string? CreatedOn { get; set; }

    public string? ActionRemarks { get; set; }

    public string? Fashortname { get; set; }

    public string? Facode { get; set; }

    public string? Aum { get; set; }

    public string? StartDate { get; set; }

    public string? IsCcApplicable { get; set; }

    public string? Cpercentage { get; set; }

    public string? CategoryTypeId { get; set; }

    public string? CategoryTypeProductType { get; set; }

    public bool? IsFundenable { get; set; }

    public int? ModifiedBy { get; set; }

    public int? ModifiedOn { get; set; }
}
