using System;
using System.Collections.Generic;

namespace DataService.Models;

public partial class Omsdealsheetuploaddetail
{
    public int Id { get; set; }

    public int? Approverid { get; set; }

    public DateTime? Approvertimestamp { get; set; }

    public string? Status { get; set; }

    public bool? Isactive { get; set; }
}
