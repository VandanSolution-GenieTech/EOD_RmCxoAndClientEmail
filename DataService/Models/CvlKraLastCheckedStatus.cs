using System;
using System.Collections.Generic;

namespace DataService.Models;

public partial class CvlKraLastCheckedStatus
{
    public int Id { get; set; }

    public int? InvId { get; set; }

    public int? HolderRankId { get; set; }

    public string? KraStatus { get; set; }

    public string? KraStatusDate { get; set; }

    public bool? IsActive { get; set; }

    public DateTime? CreatedOn { get; set; }

    public DateTime? ModifiedOn { get; set; }
}
