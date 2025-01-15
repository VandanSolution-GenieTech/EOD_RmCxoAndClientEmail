using System;
using System.Collections.Generic;

namespace DataService.Models;

public partial class Wsmfpanexemptcategory
{
    public int Id { get; set; }

    public string? Category { get; set; }

    public string? Description { get; set; }

    public DateTime? CreatedOn { get; set; }
}
