using System;
using System.Collections.Generic;

namespace DataService.Models;

public partial class GetPanAadharUrl
{
    public int Id { get; set; }

    public string? InvId { get; set; }

    public string? Request { get; set; }

    public string? Response { get; set; }

    public DateTime? Requesttimestemp { get; set; }
}
