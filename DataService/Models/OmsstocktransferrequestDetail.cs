using System;
using System.Collections.Generic;

namespace DataService.Models;

public partial class OmsstocktransferrequestDetail
{
    public int Id { get; set; }

    public int? StocktransferrequestId { get; set; }

    public string? Referencenumber { get; set; }

    public decimal? Amount { get; set; }

    public virtual Omsstocktransferrequest? Stocktransferrequest { get; set; }
}
