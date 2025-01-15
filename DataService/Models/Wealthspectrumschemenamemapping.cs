using System;
using System.Collections.Generic;

namespace DataService.Models;

public partial class Wealthspectrumschemenamemapping
{
    public int Id { get; set; }

    public int? ProductType { get; set; }

    public int? SchemeType { get; set; }

    public string? SchemeName { get; set; }

    public bool? IsActive { get; set; }

    public DateTime? CreatedOn { get; set; }

    public DateTime? ModifiedOn { get; set; }
}
