using System;
using System.Collections.Generic;

namespace DataService.Models;

public partial class VwManagementMi
{
    public string InvestorCode { get; set; } = null!;

    public string? InvestorName { get; set; }

    public string? Type { get; set; }

    public int? TypeId { get; set; }

    public string? SubLob { get; set; }

    public int? Banker { get; set; }

    public string? BankerName { get; set; }

    public int? Cso { get; set; }

    public string? Csoname { get; set; }

    public string ModeOfApplication { get; set; } = null!;

    public string? CurrentStatus { get; set; }

    public long? CurrentStatusId { get; set; }

    public string? Stage { get; set; }

    public int? StageId { get; set; }

    public long? Ageing { get; set; }

    public string Tat { get; set; } = null!;

    public long? SubLobid { get; set; }

    public DateTime? NewInWard { get; set; }

    public DateTime? ActivatedToday { get; set; }

    public DateTime? InProcess { get; set; }

    public int _0to2Days { get; set; }

    public int _3to5Days { get; set; }

    public int _6to10Days { get; set; }

    public int MoreThan10Days { get; set; }

    public DateTime? OnboardedDate { get; set; }

    public string? OnboardedMonth { get; set; }
}
