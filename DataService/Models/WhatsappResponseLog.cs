using System;
using System.Collections.Generic;

namespace DataService.Models;

public partial class WhatsappResponseLog
{
    public int Id { get; set; }

    public string? Response { get; set; }

    public DateTime? Dt { get; set; }
}
