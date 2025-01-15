using System;
using System.Collections.Generic;

namespace DataService.Models;

public partial class Citymaster
{
    public int Id { get; set; }

    public string? CityName { get; set; }

    public int? StateId { get; set; }

    public bool? IsActive { get; set; }

    public bool? IsDeleted { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }
}
