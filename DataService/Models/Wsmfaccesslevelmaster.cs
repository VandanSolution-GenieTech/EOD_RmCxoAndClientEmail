using System;
using System.Collections.Generic;

namespace DataService.Models;

public partial class Wsmfaccesslevelmaster
{
    public int Id { get; set; }

    public string? AccessLevelValue { get; set; }

    public string? Remarks { get; set; }

    public DateTime? CreatedOn { get; set; }
}
