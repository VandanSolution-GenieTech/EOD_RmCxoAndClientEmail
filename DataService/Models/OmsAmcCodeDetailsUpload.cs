using System;
using System.Collections.Generic;

namespace DataService.Models;

public partial class OmsAmcCodeDetailsUpload
{
    public string? Amccode { get; set; }

    public string? Us { get; set; }

    public string? Canada { get; set; }

    public bool? Isactive { get; set; }

    public int? Createdby { get; set; }

    public DateTime? Createdon { get; set; }

    public int Id { get; set; }
}
