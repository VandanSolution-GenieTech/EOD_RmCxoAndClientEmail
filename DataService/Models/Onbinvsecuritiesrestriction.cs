using System;
using System.Collections.Generic;

namespace DataService.Models;

public partial class Onbinvsecuritiesrestriction
{
    public int Id { get; set; }

    public int InvId { get; set; }

    public int? Type { get; set; }

    public string? CompanyName { get; set; }

    public string? Remark { get; set; }

    public bool? IsActive { get; set; }

    public int? SerialNo { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }
}
