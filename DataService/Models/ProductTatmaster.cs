using System;
using System.Collections.Generic;

namespace DataService.Models;

public partial class ProductTatmaster
{
    public int? SrNo { get; set; }

    public int? ProductId { get; set; }

    public string? AcType { get; set; }

    public string? AcCode { get; set; }

    public int? Ind { get; set; }

    public int? Nind { get; set; }

    public string? IsActive { get; set; }

    public string? IsDeleted { get; set; }

    public string? CreatedBy { get; set; }

    public string? CreatedOn { get; set; }

    public string? ModifiedBy { get; set; }

    public string? ModifiedOn { get; set; }
}
