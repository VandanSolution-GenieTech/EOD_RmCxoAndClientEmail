using System;
using System.Collections.Generic;

namespace DataService.Models;

public partial class Statemaster
{
    public int Id { get; set; }

    public string? StateName { get; set; }

    public string? IsoCode { get; set; }

    public bool? IsActive { get; set; }

    public bool? IsDeleted { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }
}
