using System;
using System.Collections.Generic;

namespace DataService.Models;

public partial class Cvkrapanenquiryrequestresponse
{
    public int Id { get; set; }

    public int? InvId { get; set; }

    public int? HolderRankId { get; set; }

    public string? Request { get; set; }

    public DateTime? RequestTimestamp { get; set; }

    public string? Response { get; set; }

    public DateTime? ResponseTimestamp { get; set; }

    public string? PanNo { get; set; }

    public string? Dob { get; set; }

    public string? AppName { get; set; }

    public string? AppStatus { get; set; }

    public string? StatusDescription { get; set; }

    public bool? IsActive { get; set; }
}
