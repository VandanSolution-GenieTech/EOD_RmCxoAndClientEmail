using System;
using System.Collections.Generic;

namespace DataService.Models;

public partial class WsEntitybroker
{
    public int Id { get; set; }

    public string? Instrumentname { get; set; }

    public string? Brokercode { get; set; }

    public bool? Isactive { get; set; }
}
