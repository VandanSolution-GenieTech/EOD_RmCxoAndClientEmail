using System;
using System.Collections.Generic;

namespace DataService.Models;

public partial class Rolemaster
{
    public int Id { get; set; }

    public string Rolename { get; set; } = null!;

    public bool? IsActive { get; set; }

    public bool? IsDeleted { get; set; }

    public int CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }
}
