using System;
using System.Collections.Generic;

namespace DataService.Models;

public partial class WsEntitynamemappingdatum
{
    public int Id { get; set; }

    public string? Wsentityname { get; set; }

    public int? Entityid { get; set; }

    public bool? Isactive { get; set; }
}
