using System;
using System.Collections.Generic;

namespace DataService.Models;

public partial class Amlscreeningdetail
{
    public int Id { get; set; }

    public int InvId { get; set; }

    public int HolderRankId { get; set; }

    public string? Pan { get; set; }

    public string? RequestId { get; set; }

    public string? RequestBody { get; set; }

    public string? ValidationCode { get; set; }

    public string? ValidationDescription { get; set; }

    public string? OverallStatus { get; set; }

    public string? ValidationOutcome { get; set; }

    public string? HitsDetected { get; set; }

    public int? HitsCount { get; set; }

    public string? ConfirmedHits { get; set; }

    public string? ReportFileName { get; set; }

    public string? ReportFilePath { get; set; }

    public bool? IsActive { get; set; }

    public DateTime? CreatedOn { get; set; }

    public DateTime? ModifiedOn { get; set; }
}
