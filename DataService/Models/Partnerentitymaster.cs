using System;
using System.Collections.Generic;

namespace DataService.Models;

public partial class Partnerentitymaster
{
    public int Id { get; set; }

    public string? EntityName { get; set; }

    public bool? IsActive { get; set; }

    public DateTime? CreatedOn { get; set; }

    public DateTime? ModifiedOn { get; set; }
}
