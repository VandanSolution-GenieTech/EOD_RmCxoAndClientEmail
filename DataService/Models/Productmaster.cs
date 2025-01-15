using System;
using System.Collections.Generic;

namespace DataService.Models;

public partial class Productmaster
{
    public int Id { get; set; }

    public string? BusinessName { get; set; }

    public string? ShortName { get; set; }

    public string? AcType { get; set; }

    public decimal? MinimumInvsestment { get; set; }

    public decimal? MinimumTopup { get; set; }

    public decimal? MinimumRedumption { get; set; }

    public decimal? MaxSetupFees { get; set; }

    public string? Product { get; set; }

    public bool? IsActive { get; set; }

    public bool? IsDeleted { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }
}
