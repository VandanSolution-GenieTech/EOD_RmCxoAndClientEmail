using System;
using System.Collections.Generic;

namespace DataService.Models;

public partial class Wsmfterminalidmaster
{
    public int Id { get; set; }

    public string? TerminalidValue { get; set; }

    public string? Remarks { get; set; }

    public DateTime? CreatedOn { get; set; }
}
