using System;
using System.Collections.Generic;

namespace DataService.Models;

public partial class Onbnoninvotherdetail
{
    public int Id { get; set; }

    public int InvId { get; set; }

    public int HolderRankId { get; set; }

    public bool? PepRpep { get; set; }

    public bool? SmsalertFacility { get; set; }

    public bool? Poa { get; set; }

    public string? RbiregNo { get; set; }

    public string? RbiregDate { get; set; }

    public int? IncomePerAnnum { get; set; }

    public int? Pmladetails { get; set; }

    public bool? SmsemailAlert { get; set; }

    public int? AccountStatement { get; set; }

    public int? AnnualReport { get; set; }

    public bool? IsActive { get; set; }

    public bool? IsDeleted { get; set; }

    public int CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public int ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }
}
