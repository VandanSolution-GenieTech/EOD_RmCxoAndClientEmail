using System;
using System.Collections.Generic;

namespace DataService.Models;

public partial class Signzynamematchrequestresponse
{
    public int Id { get; set; }

    public int? Invid { get; set; }

    public string? Request { get; set; }

    public DateTime? Requesttimestamp { get; set; }

    public string? Response { get; set; }

    public DateTime? Responsetimestamp { get; set; }

    public string? Name1VsName2MatchResult { get; set; }

    public string? Name1VsName2MatchScore { get; set; }

    public string? Name1VsName2MatchReason { get; set; }

    public ulong? Isactive { get; set; }
}
