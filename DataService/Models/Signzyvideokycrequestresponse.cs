using System;
using System.Collections.Generic;

namespace DataService.Models;

public partial class Signzyvideokycrequestresponse
{
    public int Id { get; set; }

    public int? Invid { get; set; }

    public int? HolderRankId { get; set; }

    public int? ModificationId { get; set; }

    public string? Request { get; set; }

    public DateTime? Requesttimestamp { get; set; }

    public string? Response { get; set; }

    public DateTime? Responssetimestamp { get; set; }

    public string? Vidourl { get; set; }

    public ulong? Isactive { get; set; }

    public string? IdRes { get; set; }

    public string? Token { get; set; }

    public bool? IsSent { get; set; }

    public string? Patronid { get; set; }
}
