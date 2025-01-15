using System;
using System.Collections.Generic;

namespace DataService.Models;

public partial class Wealthspectrummappingmaster
{
    public int Id { get; set; }

    public string? CategoryType { get; set; }

    public int? SystemId { get; set; }

    public string? WealthValue { get; set; }

    public string? WealthText { get; set; }

    public sbyte? IsActive { get; set; }
}
