using System;
using System.Collections.Generic;

namespace DataService.Models;

public partial class Omsnsefundetail
{
    public int Id { get; set; }

    public int? Orderhistoryid { get; set; }

    public string? GroupId { get; set; }

    public string? OwnerId { get; set; }

    public string? ClientId { get; set; }

    public string? ClientCode { get; set; }

    public string? OrderType { get; set; }

    public string? TransactionTypeName { get; set; }

    public string? AmcName { get; set; }

    public string? SchemeName { get; set; }

    public string? IsinCode { get; set; }

    public string? TrxType { get; set; }

    public string? FolioNo { get; set; }

    public decimal? Amount { get; set; }

    public string? DematNo { get; set; }

    public string? Manufacturer { get; set; }

    public decimal? CommitmentAmount { get; set; }

    public decimal? SetupFee { get; set; }

    public decimal? EquilizationAmount { get; set; }

    public decimal? Units { get; set; }

    public DateTime? TradeDate { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public bool? IsActive { get; set; }
}
