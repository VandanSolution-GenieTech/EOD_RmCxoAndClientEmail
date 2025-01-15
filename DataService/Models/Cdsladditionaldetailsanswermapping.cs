using System;
using System.Collections.Generic;

namespace DataService.Models;

public partial class Cdsladditionaldetailsanswermapping
{
    public int Id { get; set; }

    public string CategoryType { get; set; } = null!;

    public string SystemAnswer { get; set; } = null!;

    public string? CdslCode { get; set; }

    public bool? IsActive { get; set; }
}
