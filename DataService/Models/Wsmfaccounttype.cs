using System;
using System.Collections.Generic;

namespace DataService.Models;

public partial class Wsmfaccounttype
{
    public int Id { get; set; }

    public string? AccountCode { get; set; }

    public string? AccountDetails { get; set; }

    public DateTime? CreatedOn { get; set; }
}
