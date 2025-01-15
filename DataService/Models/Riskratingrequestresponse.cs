using System;
using System.Collections.Generic;

namespace DataService.Models;

public partial class Riskratingrequestresponse
{
    public int Id { get; set; }

    public int? Invid { get; set; }

    public string? Request { get; set; }

    public string? Response { get; set; }

    public DateTime? Requesttimestemp { get; set; }

    public DateTime? Responsetimestamp { get; set; }

    public ulong? Isactive { get; set; }

    public string? Riskrating { get; set; }

    public ulong? Isriskverified { get; set; }

    public int? HolderRankId { get; set; }
}
