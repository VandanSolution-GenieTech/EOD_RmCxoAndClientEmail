using System;
using System.Collections.Generic;

namespace DataService.Models;

public partial class Krastatemaster
{
    public int Id { get; set; }

    public string? StateCodeEnum { get; set; }

    public string? StateName { get; set; }

    public bool? IsActive { get; set; }

    public DateTime? CreatedOn { get; set; }

    public DateTime? ModifiedOn { get; set; }
}
