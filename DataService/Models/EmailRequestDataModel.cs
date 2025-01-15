using System;
using System.Collections.Generic;

namespace DataService.Models;

public partial class EmailRequestDataModel
{
    public int Id { get; set; }

    public int? InvId { get; set; }

    public string? EmailFromAddress { get; set; }

    public string? EmailToAddress { get; set; }

    public string? EmailCcaddress { get; set; }

    public string? EmailBccaddress { get; set; }

    public string? Attachments { get; set; }

    public string? Subject { get; set; }

    public string? Body { get; set; }

    public DateTime? TimeStamp { get; set; }
}
