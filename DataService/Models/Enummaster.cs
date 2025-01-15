using System;
using System.Collections.Generic;

namespace DataService.Models;

public partial class Enummaster
{
    public int Id { get; set; }

    public string EnumType { get; set; } = null!;

    public string EnumName { get; set; } = null!;

    public int? EnumId { get; set; }

    public int? SortRank { get; set; }

    public bool? IsActive { get; set; }

    public bool? IsDeleted { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }
}
