using System;
using System.Collections.Generic;

namespace DataService.Models;

public partial class Onbinvestordetail
{
    public int InvId { get; set; }

    public int ClientId { get; set; }

    public string Pan { get; set; } = null!;

    public DateTime? Dob { get; set; }

    public int? StatusId { get; set; }

    public int? Rmid { get; set; }

    public int? Cxoid { get; set; }

    public int? DistrunbutorId { get; set; }

    public int? ExternalDistributorId { get; set; }

    public int? BusinessTypeId { get; set; }

    public int? ProductTypeId { get; set; }

    public int? ProductId { get; set; }

    public int? SubProductTypeId { get; set; }

    public int? StructureTypeId { get; set; }

    public int? SchemeTypeId { get; set; }

    public int? FundId { get; set; }

    public int? FundStatus { get; set; }

    public decimal? SubscriptionAmount { get; set; }

    public int? SeriesId { get; set; }

    public string? SetUpEntryFee { get; set; }

    public string? Ucccode { get; set; }

    public int? BankerId { get; set; }

    public string? BankerRmname { get; set; }

    public string? BankerRmemail { get; set; }

    public string? EsignType { get; set; }

    public string? Riacode { get; set; }

    public string? NoChangeDeclaration { get; set; }

    public string? AppId { get; set; }

    public string? RiskRating { get; set; }

    public string? PastActionDeclaration { get; set; }

    public string? DetailsOfPastAction { get; set; }

    public decimal? InvestmentLimits { get; set; }

    public bool? IsCopyData { get; set; }

    public string? FeeType { get; set; }

    public bool? IsTransfer { get; set; }

    public string? CheckerRejectedRemarks { get; set; }

    public string? HoscanCopyRejectedRemarks { get; set; }

    public string? FormDispatchDetails { get; set; }

    public bool? IsExpress { get; set; }

    public bool? IsPhysicalDigital { get; set; }

    public decimal? ExpectedCorpus { get; set; }

    public bool? IsActive { get; set; }

    public bool? IsDeleted { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }
}
