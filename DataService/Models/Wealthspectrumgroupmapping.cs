using System;
using System.Collections.Generic;

namespace DataService.Models;

public partial class Wealthspectrumgroupmapping
{
    public int Id { get; set; }

    public int? SubLobId { get; set; }

    public string? GroupName { get; set; }

    public string? GroupCode { get; set; }

    public bool? IsActive { get; set; }

    public DateTime? CreatedOn { get; set; }

    public DateTime? ModifiedOn { get; set; }
}
