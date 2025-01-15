using System;
using System.Collections.Generic;

namespace DataService.Models;

public partial class Bseclassmastersmapping
{
    public int Id { get; set; }

    public string CategoryType { get; set; } = null!;

    public int SystemId { get; set; }

    public string? BseCode { get; set; }

    public bool? IsActive { get; set; }
}
