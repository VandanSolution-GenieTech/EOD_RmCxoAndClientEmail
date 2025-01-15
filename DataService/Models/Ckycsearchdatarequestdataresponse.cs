using System;
using System.Collections.Generic;

namespace DataService.Models;

public partial class Ckycsearchdatarequestdataresponse
{
    public int Id { get; set; }

    public int? InvId { get; set; }

    public int? Holderrankid { get; set; }

    public string? Request { get; set; }

    public DateTime? Requesttimestamp { get; set; }

    public ulong? Isactive { get; set; }

    public string? Response { get; set; }

    public DateTime? Responsetimestamp { get; set; }

    public string? Ckycnumber { get; set; }

    public string? Fullname { get; set; }

    public int? Age { get; set; }
}
