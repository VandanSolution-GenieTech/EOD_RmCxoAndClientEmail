using System;
using System.Collections.Generic;

namespace DataService.Models;

public partial class Classdpmastermapping
{
    public int Id { get; set; }

    public string? CategoryType { get; set; }

    public int? SystemId { get; set; }

    public string? ClassCode { get; set; }

    public bool? IsActive { get; set; }
}
