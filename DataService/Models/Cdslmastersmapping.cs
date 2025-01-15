using System;
using System.Collections.Generic;

namespace DataService.Models;

public partial class Cdslmastersmapping
{
    public int Id { get; set; }

    public string CategoryType { get; set; } = null!;

    public int SystemId { get; set; }

    public string? CdslCode { get; set; }

    public bool? IsActive { get; set; }
}
