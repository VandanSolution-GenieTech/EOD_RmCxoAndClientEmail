using System;
using System.Collections.Generic;

namespace DataService.Models;

public partial class SchedulerServiceErrorLog
{
    public int Id { get; set; }

    public string? SchedulerName { get; set; }

    public string? MethodName { get; set; }

    public string? ExceptionType { get; set; }

    public string? ExceptionMessage { get; set; }

    public string? StackTrace { get; set; }

    public DateTime? CreatedOn { get; set; }
}
