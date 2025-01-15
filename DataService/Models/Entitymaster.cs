using System;
using System.Collections.Generic;

namespace DataService.Models;

public partial class Entitymaster
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Shopname { get; set; }

    public string? Pan { get; set; }

    public DateOnly? DateOfInitiation { get; set; }

    public string? Gstno { get; set; }

    public string? Cinnumber { get; set; }

    public string? Arnno { get; set; }

    public string? ResiAddress { get; set; }

    public decimal? ContactPerson { get; set; }

    public decimal? Mobile { get; set; }

    public string? Emailid { get; set; }

    public string? Status { get; set; }

    public bool? IsActive { get; set; }

    public bool? IsDeleted { get; set; }

    public int? Createdby { get; set; }

    public DateTime? CreatedOn { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }
}
