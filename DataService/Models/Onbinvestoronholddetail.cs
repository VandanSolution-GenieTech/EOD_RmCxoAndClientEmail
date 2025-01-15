using System;
using System.Collections.Generic;

namespace DataService.Models;

public partial class Onbinvestoronholddetail
{
    public int Id { get; set; }

    public int? InvId { get; set; }

    public bool? OnHold { get; set; }

    public string? HoldReason { get; set; }

    public DateTime? HoldDate { get; set; }

    public int? HoldBy { get; set; }

    public DateTime? UnholdDate { get; set; }

    public int? UnholdBy { get; set; }

    public int? NewInvId { get; set; }

    public bool? IsActive { get; set; }

    public DateTime? CreatedOn { get; set; }

    public DateTime? ModifiedOn { get; set; }
}
