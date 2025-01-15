using System;
using System.Collections.Generic;

namespace DataService.Models;

public partial class Validatevideokyc
{
    public int Id { get; set; }

    public string? Reqid { get; set; }

    public string? Token { get; set; }

    public string? Patronid { get; set; }

    public string? Response { get; set; }

    public DateTime? Responsetimestamp { get; set; }

    public bool? Isvalidated { get; set; }
}
