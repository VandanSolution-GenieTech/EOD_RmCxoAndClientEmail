using System;
using System.Collections.Generic;

namespace DataService.Models;

public partial class Omsactiveordermaster
{
    public int Id { get; set; }

    public string? Accounttype { get; set; }

    public bool? Fixedincome { get; set; }

    public bool? Listed { get; set; }

    public bool? Unlisted { get; set; }

    public bool? Mutualfund { get; set; }

    public bool? Aif { get; set; }

    public bool? Isactive { get; set; }
}
