using System;
using System.Collections.Generic;

namespace DataService.Models;

public partial class Signzypanstatusresponse
{
    public int Id { get; set; }

    public int? Invid { get; set; }

    public string? Pan { get; set; }

    public string? Request { get; set; }

    public string? Response { get; set; }

    public string? Seedingstatus { get; set; }

    public string? Panstatusdescription { get; set; }
}
