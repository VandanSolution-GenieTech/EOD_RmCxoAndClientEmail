using System;
using System.Collections.Generic;

namespace DataService.Models;

public partial class Wsmfstatemaster
{
    public int Id { get; set; }

    public string? StateCodeValue { get; set; }

    public string? StateName { get; set; }

    public DateTime? CreatedOn { get; set; }
}
