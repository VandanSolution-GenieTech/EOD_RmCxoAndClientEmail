using System;
using System.Collections.Generic;

namespace DataService.Models;

public partial class ExceptionLog
{
    public int Id { get; set; }

    public string Message { get; set; } = null!;

    public string StackTrace { get; set; } = null!;

    public DateTime Timestamp { get; set; }
}
