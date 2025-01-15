using System;
using System.Collections.Generic;

namespace DataService.Models;

public partial class Wealthspectrumclientid
{
    public int Id { get; set; }

    public string? Pan { get; set; }

    public string? Wstype { get; set; }

    public string? AccountType { get; set; }

    public int? ClientId { get; set; }

    public bool? IsActive { get; set; }

    public DateTime? CreatedOn { get; set; }

    public DateTime? ModifiedOn { get; set; }
}
