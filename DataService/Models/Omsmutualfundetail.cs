using System;
using System.Collections.Generic;

namespace DataService.Models;

public partial class Omsmutualfundetail
{
    public int Id { get; set; }

    public int? Orderhistoryid { get; set; }

    public string? GroupId { get; set; }

    public string? OwnerId { get; set; }

    public string? ClientId { get; set; }

    public string? ClientCode { get; set; }

    public string? OrderType { get; set; }

    public string? Orderby { get; set; }

    public string? TransactionTypeName { get; set; }

    public string? AmcName { get; set; }

    public string? SchemeName { get; set; }

    public string? IsinCode { get; set; }

    public string? TrxType { get; set; }

    public string? FolioNo { get; set; }

    public decimal? Amount { get; set; }

    public int? Units { get; set; }

    public string? EiunCode { get; set; }

    public string? HoldingPattern { get; set; }

    public string? DematNo { get; set; }

    public string? SchemeCode { get; set; }

    public string? Mode { get; set; }

    public DateTime? TradeDate { get; set; }

    public int? Createdby { get; set; }

    public DateTime? Createdon { get; set; }

    public bool? IsActive { get; set; }

    public bool? Isallredeem { get; set; }

    public decimal? AvailableAmount { get; set; }

    public decimal? AvailableUnits { get; set; }
}
