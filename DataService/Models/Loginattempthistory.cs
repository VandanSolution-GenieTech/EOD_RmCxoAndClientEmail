using System;
using System.Collections.Generic;

namespace DataService.Models;

public partial class Loginattempthistory
{
    public int Id { get; set; }

    public int? UserId { get; set; }

    public long? Otp { get; set; }

    public DateTime? Time { get; set; }

    public string? Ip { get; set; }

    public string? UserAgent { get; set; }

    public string? Browser { get; set; }

    public string? OperatingSystem { get; set; }

    public string? Device { get; set; }

    public bool? IsSuccess { get; set; }
}
