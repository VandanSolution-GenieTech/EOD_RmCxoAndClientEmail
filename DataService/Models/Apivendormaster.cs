using System;
using System.Collections.Generic;

namespace DataService.Models;

public partial class Apivendormaster
{
    public int Id { get; set; }

    public string VendorName { get; set; } = null!;

    public bool? IsActive { get; set; }

    public DateTime? CreatedOn { get; set; }

    public DateTime? ModifiedOn { get; set; }
}
