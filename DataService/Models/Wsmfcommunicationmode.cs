using System;
using System.Collections.Generic;

namespace DataService.Models;

public partial class Wsmfcommunicationmode
{
    public int Id { get; set; }

    public string? Code { get; set; }

    public string? Description { get; set; }

    public DateTime? CreatedOn { get; set; }
}
