using System;
using System.Collections.Generic;

namespace DataService.Models;

public partial class Bsestarmastersmapping
{
    public int Id { get; set; }

    public string CategoryType { get; set; } = null!;

    public int SystemId { get; set; }

    public string? StarCode { get; set; }

    public bool? IsActive { get; set; }
}
