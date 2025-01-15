using System;
using System.Collections.Generic;

namespace DataService.Models;

public partial class Credentialssignzyesign
{
    public int Id { get; set; }

    public int EntityId { get; set; }

    public string Authorization { get; set; } = null!;

    public bool IsActive { get; set; }

    public DateTime? CreatedOn { get; set; }

    public DateTime? ModifiedOn { get; set; }
}
