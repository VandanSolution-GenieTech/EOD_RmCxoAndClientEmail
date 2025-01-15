using System;
using System.Collections.Generic;

namespace DataService.Models;

public partial class Signzyesignestamppaper
{
    public int Id { get; set; }

    public int ProductId { get; set; }

    public int? PdfType { get; set; }

    public string? StateCode { get; set; }

    public string? ArticleCode { get; set; }

    public int? StampDutyValue { get; set; }

    public int? Count { get; set; }

    public string? PurposeOfStampDuty { get; set; }

    public string? CustmonDefacement { get; set; }

    public bool? IsActive { get; set; }

    public DateTime? CreatedOn { get; set; }

    public DateTime? ModifiedOn { get; set; }
}
