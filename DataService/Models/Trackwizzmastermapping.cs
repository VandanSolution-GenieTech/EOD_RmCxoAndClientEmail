using System;
using System.Collections.Generic;

namespace DataService.Models;

public partial class Trackwizzmastermapping
{
    public int Id { get; set; }

    public string? CategoryType { get; set; }

    public int? SystemId { get; set; }

    public string? Code { get; set; }

    public bool? IsActive { get; set; }
}
