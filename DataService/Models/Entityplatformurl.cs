using System;
using System.Collections.Generic;

namespace DataService.Models;

public partial class Entityplatformurl
{
    public int Id { get; set; }

    public int? EntityId { get; set; }

    public string? PlatformUrl { get; set; }

    public bool? IsActive { get; set; }

    public DateTime? CreatedOn { get; set; }

    public DateTime? ModifiedOn { get; set; }
}
