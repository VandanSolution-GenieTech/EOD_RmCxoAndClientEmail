using System;
using System.Collections.Generic;

namespace DataService.Models;

public partial class Onbinvtradingdetail
{
    public int Id { get; set; }

    public int InvId { get; set; }

    public string Segments { get; set; } = null!;

    public int TradingParticularId { get; set; }

    public decimal? Bsensecm1 { get; set; }

    public decimal? Bsensecm2 { get; set; }

    public decimal? Bsensefofuture { get; set; }

    public decimal? Bsensefooption { get; set; }

    public decimal? Nsecdfuture { get; set; }

    public decimal? Nsecdoption { get; set; }

    public bool? IsActive { get; set; }

    public bool? IsDeleted { get; set; }

    public int CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public int ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }
}
