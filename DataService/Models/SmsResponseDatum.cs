using System;
using System.Collections.Generic;

namespace DataService.Models;

public partial class SmsResponseDatum
{
    public int IncrementId { get; set; }

    public string? PhoneNumber { get; set; }

    public string? Details { get; set; }

    public string? Id { get; set; }

    public string? Status { get; set; }

    public DateTime? TimeStamp { get; set; }
}
