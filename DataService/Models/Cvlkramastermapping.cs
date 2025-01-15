using System;
using System.Collections.Generic;

namespace DataService.Models;

public partial class Cvlkramastermapping
{
    public int Id { get; set; }

    public string? CategoryType { get; set; }

    public int? SystemId { get; set; }

    public string? CvlCode { get; set; }

    public bool? IsActive { get; set; }
}
