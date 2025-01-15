using System;
using System.Collections.Generic;

namespace DataService.Models;

public partial class Onbinvsecuritiesinvestmentlimit
{
    public int Id { get; set; }

    public int InvId { get; set; }

    public decimal? EquitySingleAssociate { get; set; }

    public decimal? EquityMultipleAssociates { get; set; }

    public decimal? DebtSingleAssociate { get; set; }

    public decimal? DebtMultipleAssociates { get; set; }

    public decimal? EquityDebtHybrid { get; set; }

    public bool? IsActive { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }
}
