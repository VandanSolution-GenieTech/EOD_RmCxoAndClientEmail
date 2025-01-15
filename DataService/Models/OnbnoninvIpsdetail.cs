using System;
using System.Collections.Generic;

namespace DataService.Models;

public partial class OnbnoninvIpsdetail
{
    public int Id { get; set; }

    public int InvId { get; set; }

    public int HolderRankId { get; set; }

    public int? PortfolioChoice { get; set; }

    public int? PortFolioOption { get; set; }

    public string? Corpus { get; set; }

    public bool? IsActive { get; set; }

    public bool? IsDeleted { get; set; }

    public int CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public int ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }
}
