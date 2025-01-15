using System;
using System.Collections.Generic;

namespace DataService.Models;

public partial class Wealthspectrumupdatenomineesapilog
{
    public int Id { get; set; }

    public int? InvId { get; set; }

    public int? ClientId { get; set; }

    public int? NomineeRankId { get; set; }

    public bool? Success { get; set; }

    public string? Request { get; set; }

    public string? Response { get; set; }

    public bool? IsActive { get; set; }

    public DateTime? CreatedOn { get; set; }

    public DateTime? ModifiedOn { get; set; }
}
