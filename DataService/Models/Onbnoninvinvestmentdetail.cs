using System;
using System.Collections.Generic;

namespace DataService.Models;

public partial class Onbnoninvinvestmentdetail
{
    public int Id { get; set; }

    public int InvId { get; set; }

    public int HolderRankId { get; set; }

    public string? CommitmentAmount { get; set; }

    public string? InitialContribution { get; set; }

    public string? Class { get; set; }

    public string? SetUpFee { get; set; }

    public string? Pepdeclaration { get; set; }

    public bool? IsActive { get; set; }

    public bool? IsDeleted { get; set; }

    public int CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public int ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }
}
