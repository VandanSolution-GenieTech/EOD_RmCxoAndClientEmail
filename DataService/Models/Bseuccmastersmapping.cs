using System;
using System.Collections.Generic;

namespace DataService.Models;

public partial class Bseuccmastersmapping
{
    public int Id { get; set; }

    public string CategoryType { get; set; } = null!;

    public int SystemId { get; set; }

    public string? UccCode { get; set; }

    public bool? IsActive { get; set; }
}
