using System;
using System.Collections.Generic;

namespace DataService.Models;

public partial class Amlscreenningrequestresponse
{
    public int Id { get; set; }

    public int? Invid { get; set; }

    public int? Holderrankid { get; set; }

    public string? Request { get; set; }

    public string? Response { get; set; }

    public DateTime? Requesttimestemp { get; set; }

    public DateTime? Responsetimestamp { get; set; }

    public string? Responseid { get; set; }

    public string? Requestid { get; set; }

    public string? Amlmatch { get; set; }

    public int? Amlalertcount { get; set; }

    public string? Rejectionmessage { get; set; }

    public string? Link { get; set; }

    public ulong? Isactive { get; set; }

    public string? Rejectioncode { get; set; }
}
