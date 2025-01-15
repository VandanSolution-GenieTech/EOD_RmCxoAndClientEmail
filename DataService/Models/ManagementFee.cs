using System;
using System.Collections.Generic;

namespace DataService.Models;

public partial class ManagementFee
{
    public int Id { get; set; }

    public int? Productid { get; set; }

    public int? EntityId { get; set; }

    public int? Externaldistributorid { get; set; }

    public string? Corpusrange { get; set; }

    public decimal? MinimumCorpus { get; set; }

    public decimal? MaximumCorpus { get; set; }

    public decimal? ManagementFee1 { get; set; }

    public string? Frequency { get; set; }

    public bool? IsDefault { get; set; }

    public bool? IsActive { get; set; }

    public bool? IsDeleted { get; set; }

    public int? Createdby { get; set; }

    public DateTime? CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }
}
