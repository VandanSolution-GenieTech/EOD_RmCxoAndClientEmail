using System;
using System.Collections.Generic;

namespace DataService.Models;

public partial class Readyfortradeattachment
{
    public int Id { get; set; }

    public int InvId { get; set; }

    public string? FileName { get; set; }

    public string? FilePath { get; set; }

    public bool? IsActive { get; set; }

    public DateTime? CreatedOn { get; set; }

    public DateTime? ModfiedOn { get; set; }
}
