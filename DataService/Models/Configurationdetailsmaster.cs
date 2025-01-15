using System;
using System.Collections.Generic;

namespace DataService.Models;

public partial class Configurationdetailsmaster
{
    public int Id { get; set; }

    public string? Keyname { get; set; }

    public string? Content { get; set; }

    public bool? Isactive { get; set; }
}
