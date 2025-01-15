using System;
using System.Collections.Generic;

namespace DataService.Models;

public partial class OmsstockapprovalequestDetail
{
    public int Id { get; set; }

    public int? StocktransferrequestId { get; set; }

    public string? Referencenumber { get; set; }

    public decimal? Amount { get; set; }

    public bool? Isactive { get; set; }

    public virtual Omsstockapprovalrequest? Stocktransferrequest { get; set; }
}
