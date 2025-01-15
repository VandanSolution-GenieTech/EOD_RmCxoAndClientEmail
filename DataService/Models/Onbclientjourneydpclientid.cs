using System;
using System.Collections.Generic;

namespace DataService.Models;

public partial class Onbclientjourneydpclientid
{
    public int Id { get; set; }

    public int InvId { get; set; }

    public string? DpName { get; set; }

    public string? DpId { get; set; }

    public string? ClientId { get; set; }

    public bool? IsActive { get; set; }

    public DateTime? CreatedOn { get; set; }

    public DateTime? ModifiedOn { get; set; }
}
