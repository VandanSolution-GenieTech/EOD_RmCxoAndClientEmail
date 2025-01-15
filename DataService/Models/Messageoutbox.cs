using System;
using System.Collections.Generic;

namespace DataService.Models;

public partial class Messageoutbox
{
    public int Id { get; set; }

    public int? Invd { get; set; }

    public string? Mobilenumber { get; set; }

    public string? Messagebody { get; set; }

    public string? Project { get; set; }

    public bool? Issmssent { get; set; }

    public string? Responsebody { get; set; }

    public DateTime? Createdon { get; set; }

    public bool? Isactive { get; set; }
}
