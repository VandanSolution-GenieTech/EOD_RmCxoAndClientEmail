using System;
using System.Collections.Generic;

namespace DataService.Models;

public partial class WsStagingDpdetailsdatum
{
    public int Id { get; set; }

    public string? GroupId { get; set; }

    public string? OwnerId { get; set; }

    public string? ClientId { get; set; }

    public string? ClientCode { get; set; }

    public string? TradingDpId { get; set; }

    public string? AccountType { get; set; }

    public string? TradingDpType { get; set; }

    public bool? IsPrimary { get; set; }

    public bool? IsPoa { get; set; }

    public bool? Isactive { get; set; }

    public DateTime? Timestamp { get; set; }
}
