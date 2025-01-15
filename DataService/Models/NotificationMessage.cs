using System;
using System.Collections.Generic;

namespace DataService.Models;

public partial class NotificationMessage
{
    public int Id { get; set; }

    public int? Nmid { get; set; }

    public int? EntityId { get; set; }

    public string? FromAddress { get; set; }

    public string? ToAddress { get; set; }

    public string? Ccaddress { get; set; }

    public string? BccAddress { get; set; }

    public string? Attachment { get; set; }

    public string? Emailbody { get; set; }

    public bool? Ismailsent { get; set; }

    public string? Emailresponse { get; set; }

    public bool? Isactive { get; set; }

    public DateTime? Timestamp { get; set; }

    public string? Subject { get; set; }

    public int? Invid { get; set; }

    public string? ClientCode { get; set; }
}
