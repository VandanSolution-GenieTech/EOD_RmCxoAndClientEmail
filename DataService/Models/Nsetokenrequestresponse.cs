using System;
using System.Collections.Generic;

namespace DataService.Models;

public partial class Nsetokenrequestresponse
{
    public int Id { get; set; }

    public string? Token { get; set; }

    public DateTime? Timestamp { get; set; }
}
