using System;
using System.Collections.Generic;

namespace DataService.Models;

public partial class VwMonthlyMisEvaluate
{
    public string? Product { get; set; }

    public int? EntityId { get; set; }

    public int? LobId { get; set; }

    public long MonthlyTillDate { get; set; }

    public long April { get; set; }

    public long May { get; set; }

    public long June { get; set; }

    public long July { get; set; }

    public long August { get; set; }

    public long September { get; set; }

    public long October { get; set; }

    public long November { get; set; }

    public long December { get; set; }

    public long January { get; set; }

    public long February { get; set; }

    public long March { get; set; }
}
