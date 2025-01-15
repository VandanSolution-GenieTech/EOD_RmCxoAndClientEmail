using System;
using System.Collections.Generic;

namespace DataService.Models;

public partial class Onbinvtradingsegmentselection
{
    public int Id { get; set; }

    public int InvId { get; set; }

    public bool? CashMfSelection { get; set; }

    public bool? FnOselection { get; set; }

    public bool? CurrencySelection { get; set; }

    public bool? DebtSelection { get; set; }

    public bool? AllSelection { get; set; }

    public bool? IsActive { get; set; }

    public int CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public int ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }
}
