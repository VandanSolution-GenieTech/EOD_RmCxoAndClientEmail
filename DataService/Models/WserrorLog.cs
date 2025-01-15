using System;
using System.Collections.Generic;

namespace DataService.Models;

public partial class WserrorLog
{
    public int Id { get; set; }

    public string MethodName { get; set; } = null!;

    public string? Route { get; set; }

    public string? ExceptionType { get; set; }

    public string? Message { get; set; }

    public string? StackTrace { get; set; }

    public DateTime? CreatedOn { get; set; }
}
