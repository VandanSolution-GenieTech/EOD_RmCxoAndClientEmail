using System;
using System.Collections.Generic;

namespace DataService.Models;

public partial class WsBseDataurl
{
    public int Id { get; set; }

    public string? ServiceProvider { get; set; }

    public string? Url { get; set; }

    public int? Flag { get; set; }

    public string? FlagDesc { get; set; }

    public bool? IsActive { get; set; }
}
