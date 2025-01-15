using System;
using System.Collections.Generic;

namespace DataService.Models;

public partial class Signzyidentityrequestresponse
{
    public int Id { get; set; }

    public int? Invid { get; set; }

    public int? Holderrankid { get; set; }

    public string? Request { get; set; }

    public DateTime? Requesttimestamp { get; set; }

    public string? Response { get; set; }

    public DateTime? Responsetimestamp { get; set; }

    public string? Itemid { get; set; }

    public string? Accesstoken { get; set; }

    public ulong? Isactive { get; set; }
}
