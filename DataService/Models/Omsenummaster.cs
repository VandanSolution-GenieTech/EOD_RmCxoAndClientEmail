using System;
using System.Collections.Generic;

namespace DataService.Models;

public partial class Omsenummaster
{
    public int Id { get; set; }

    public string? Enumtype { get; set; }

    public string Enumname { get; set; } = null!;

    public int? Enumid { get; set; }

    public int? SortRank { get; set; }

    public bool? Isactive { get; set; }

    public bool? Isdeleted { get; set; }

    public int? Createdby { get; set; }

    public DateTime? Createdon { get; set; }

    public int? Modifiedby { get; set; }

    public DateTime? Modifiedon { get; set; }
}
