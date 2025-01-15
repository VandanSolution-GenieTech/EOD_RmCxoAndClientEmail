using System;
using System.Collections.Generic;

namespace DataService.Models;

public partial class Onbnoninvfatcadetail
{
    public int Id { get; set; }

    public int InvId { get; set; }

    public int HolderRankId { get; set; }

    public bool ResidentIndia { get; set; }

    public bool? RegisteredAddress { get; set; }

    public bool? Applicable { get; set; }

    public bool? DirectReportingNfe { get; set; }

    public string? HaveOwnGiin { get; set; }

    public string? Giin { get; set; }

    public string? HaveSponsoredEntityGiin { get; set; }

    public string? GiinofSponsoringEntity { get; set; }

    public string? NameofSponsoringEntity { get; set; }

    public string? AppliedNotRequiredNotObt { get; set; }

    public int? SpecifyCategory { get; set; }

    public string? Crsjurisdiction { get; set; }

    public string? InvestmentEntity { get; set; }

    public string? EntityType { get; set; }

    public string? PublicTradedCompany { get; set; }

    public string? StockExchange { get; set; }

    public string? RelatedEntity { get; set; }

    public string? SubsidiaryControlled { get; set; }

    public bool? ControlledLabel { get; set; }

    public string? NameofPublictradeCompany { get; set; }

    public string? NameofStockExchange { get; set; }

    public bool? ActivePassiveNfe { get; set; }

    public int? SubCategory { get; set; }

    public string? ActiveBusiness { get; set; }

    public string? PassiveBusiness { get; set; }

    public string? BankPoaA { get; set; }

    public string? BankPoaE { get; set; }

    public string? BankPoaE0 { get; set; }

    public string? BankPoaE1 { get; set; }

    public string? BankPoaE2 { get; set; }

    public string? BankPoaE3 { get; set; }

    public string? BankPoaE4 { get; set; }

    public string? BankPoaE5 { get; set; }

    public string? BankPoaE6 { get; set; }

    public bool? IsActive { get; set; }

    public bool? IsDeleted { get; set; }

    public int CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public int ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }
}
