using System;
using System.Collections.Generic;

namespace DataService.Models;

public partial class Sublobfamilymapping
{
    public int Id { get; set; }

    public int SubLobId { get; set; }

    public string? GroupName { get; set; }

    public string? GroupContactName { get; set; }

    public string? GroupShortCode { get; set; }

    public string? LobName { get; set; }

    public string? SubLobName { get; set; }

    public bool? IsActive { get; set; }

    public DateTime? CreatedOn { get; set; }

    public DateTime? ModifiedOn { get; set; }
}
