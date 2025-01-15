using System;
using System.Collections.Generic;

namespace DataService.Models;

public partial class NotificationMaster
{
    public int Id { get; set; }

    public string? Templatetype { get; set; }

    public string? Templatebody { get; set; }

    public bool? IsActive { get; set; }

    public string? DefaultFromAddress { get; set; }

    public string? DefaultToAddress { get; set; }

    public string? DefaultCcaddress { get; set; }

    public string? DefaultBccAddress { get; set; }

    public DateTime? Timestamp { get; set; }
}
