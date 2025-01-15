using System;
using System.Collections.Generic;

namespace DataService.Models;

public partial class Kraoccupationmaster
{
    public int Id { get; set; }

    public string? IncomeCode { get; set; }

    public string? NeoCode { get; set; }

    public int? IncomeName { get; set; }

    public bool? IsActive { get; set; }

    public DateTime? CreatedOn { get; set; }

    public DateTime? ModifiedOn { get; set; }
}
