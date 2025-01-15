using System;
using System.Collections.Generic;

namespace DataService.Models;

public partial class Omsdocumenttypemaster
{
    public int Id { get; set; }

    public string? Documentname { get; set; }

    public bool? Isactive { get; set; }

    public int? Createby { get; set; }

    public DateTime? Createdon { get; set; }

    public int? Modifiedby { get; set; }

    public DateTime? Modifiedon { get; set; }
}
