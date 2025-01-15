using System;
using System.Collections.Generic;

namespace DataService.Models;

public partial class Onbinvinvestmentdetail
{
    public int Id { get; set; }

    public int InvId { get; set; }

    public decimal? CommitmentAmount { get; set; }

    public decimal? InitialContribution { get; set; }

    public decimal? SetUpFees { get; set; }

    public int? Class { get; set; }

    public decimal? ManagementFees { get; set; }

    public string? ManagementFeesFrequency { get; set; }

    public decimal? PerformanceFees { get; set; }

    public string? PerformanceFeesFrequency { get; set; }

    public decimal? ExitLoadUpto3Months { get; set; }

    public decimal? ExitLoadUpto6Months { get; set; }

    public decimal? ExitLoadUpto1Year { get; set; }

    public decimal? ExitLoadUpto2Years { get; set; }

    public decimal? ExitLoadUpto3Years { get; set; }

    public decimal? OtherChanges { get; set; }

    public string? OtherFrequency { get; set; }

    public bool? CashSelection { get; set; }

    public bool? StockSelection { get; set; }

    public decimal? CashAmount { get; set; }

    public decimal? StockAmount { get; set; }

    public bool? IsActive { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }
}
