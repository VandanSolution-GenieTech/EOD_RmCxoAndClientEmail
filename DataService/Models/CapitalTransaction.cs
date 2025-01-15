using System;
using System.Collections.Generic;

namespace DataService.Models;

public partial class CapitalTransaction
{
    public int Id { get; set; }

    public decimal? Debit { get; set; }

    public int? ClientId { get; set; }

    public string? ClientCode { get; set; }

    public string? ClientName { get; set; }

    public string? TransactionType { get; set; }

    public string? CapitalFlow { get; set; }

    public string? TransactionDescription { get; set; }

    public string? Security { get; set; }

    public string? SecurityDescription { get; set; }

    public int? TransactionRefId { get; set; }

    public decimal? Credit { get; set; }

    public string? SecurityType { get; set; }

    public string? Remarks { get; set; }

    public string? ClientRef4 { get; set; }

    public string? ClientRef3 { get; set; }

    public string? AssetClass { get; set; }

    public DateOnly? TransactionDate { get; set; }

    public string? ClientRef2 { get; set; }

    public string? SchemeName { get; set; }

    public string? ClientRef1 { get; set; }

    public DateTime? ToDate { get; set; }

    public string? Scope { get; set; }

    public string? ScopeId { get; set; }
}
