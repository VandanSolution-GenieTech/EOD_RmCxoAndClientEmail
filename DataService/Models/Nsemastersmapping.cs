using System;
using System.Collections.Generic;

namespace DataService.Models;

public partial class Nsemastersmapping
{
    public int Id { get; set; }

    public string CategoryType { get; set; } = null!;

    public int SystemId { get; set; }

    public string? NseCode { get; set; }

    public bool? IsActive { get; set; }
}
