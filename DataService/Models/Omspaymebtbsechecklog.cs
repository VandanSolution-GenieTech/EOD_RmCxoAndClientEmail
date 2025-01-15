using System;
using System.Collections.Generic;

namespace DataService.Models;

public partial class Omspaymebtbsechecklog
{
    public int Id { get; set; }

    public string? Request { get; set; }

    public string? Response { get; set; }

    public int? UserId { get; set; }

    public DateTime? CreatedOn { get; set; }
}
