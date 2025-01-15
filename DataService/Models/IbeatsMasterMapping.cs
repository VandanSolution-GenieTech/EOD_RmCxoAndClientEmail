using System;
using System.Collections.Generic;

namespace DataService.Models;

public partial class IbeatsMasterMapping
{
    public int Id { get; set; }

    public string? CategoryType { get; set; }

    public int? SystemId { get; set; }

    public string? IbeatsCode { get; set; }

    public string? IbeatsDisplayName { get; set; }

    public bool? IsActive { get; set; }

    public DateTime? CreatedOn { get; set; }

    public DateTime? ModifiedOn { get; set; }
}
