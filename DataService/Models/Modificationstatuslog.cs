using System;
using System.Collections.Generic;

namespace DataService.Models;

public partial class Modificationstatuslog
{
    public int Id { get; set; }

    public int ModificationId { get; set; }

    public int? StatusId { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }
}
