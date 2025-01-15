using System;
using System.Collections.Generic;

namespace DataService.Models;

public partial class SmsRequestDatum
{
    public int IncrementId { get; set; }

    public string Message { get; set; } = null!;

    public string Version { get; set; } = null!;

    public string UserId { get; set; } = null!;

    public string Password { get; set; } = null!;

    public string SendTo { get; set; } = null!;

    public string MessageType { get; set; } = null!;

    public string Method { get; set; } = null!;

    public string Format { get; set; } = null!;

    public DateTime? TimeStamp { get; set; }
}
