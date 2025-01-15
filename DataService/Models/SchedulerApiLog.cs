using System;
using System.Collections.Generic;

namespace DataService.Models;

public partial class SchedulerApiLog
{
    public int Id { get; set; }

    public string? Url { get; set; }

    public string? Request { get; set; }

    public string? Response { get; set; }

    public DateTime? RequestTime { get; set; }

    public DateTime? ResponseTime { get; set; }
}
