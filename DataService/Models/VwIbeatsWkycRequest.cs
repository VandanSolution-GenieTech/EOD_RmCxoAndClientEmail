using System;
using System.Collections.Generic;

namespace DataService.Models;

public partial class VwIbeatsWkycRequest
{
    public int InvId { get; set; }

    public string? FormNo { get; set; }

    public string? AccountCode { get; set; }

    public int Products { get; set; }

    public int EditId { get; set; }

    public DateTime EditDtm { get; set; }
}
