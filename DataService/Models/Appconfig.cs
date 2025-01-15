using System;
using System.Collections.Generic;

namespace DataService.Models;

public partial class Appconfig
{
    public int Id { get; set; }

    public string? Key { get; set; }

    public string? Value { get; set; }

    public bool? IsActive { get; set; }
}
