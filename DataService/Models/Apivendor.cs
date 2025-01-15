using System;
using System.Collections.Generic;

namespace DataService.Models;

public partial class Apivendor
{
    public int Id { get; set; }

    public string? VendorName { get; set; }

    public int EntityId { get; set; }

    public string? Apiname { get; set; }

    public string? S1 { get; set; }

    public string? S2 { get; set; }

    public string? S3 { get; set; }

    public string? S4 { get; set; }

    public string? S5 { get; set; }

    public string Status { get; set; } = null!;

    public bool IsActive { get; set; }

    public bool IsDeleted { get; set; }

    public int? Createby { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? Modifiedby { get; set; }

    public DateTime? ModifiedDate { get; set; }
}
