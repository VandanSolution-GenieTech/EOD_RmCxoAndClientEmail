using System;
using System.Collections.Generic;

namespace DataService.Models;

public partial class Omsmutualfunddatahistory
{
    public int Id { get; set; }

    public string? ReferenceNumber { get; set; }

    public int? ProductId { get; set; }

    public int? InvId { get; set; }

    public int? BankId { get; set; }

    public int? DpId { get; set; }

    public string? OrderType { get; set; }

    public int? ScriptId { get; set; }

    public int? AmcId { get; set; }

    public string? IsinCode { get; set; }

    public string? UccCode { get; set; }

    public string? TransactionListType { get; set; }

    public string? TransactionType { get; set; }

    public bool? AllRedeemed { get; set; }

    public string? FolioNo { get; set; }

    public string? OrderedBy { get; set; }

    public decimal? OrderByAmount { get; set; }

    public int? OrderByUnits { get; set; }

    public string? EuinCode { get; set; }

    public string? HoldingPattern { get; set; }

    public string? DematAcNo { get; set; }

    public string? SchemeCode { get; set; }

    public string? Mode { get; set; }

    public int? AvailableUnits { get; set; }

    public decimal? AvailableAmount { get; set; }

    public string? AmcName { get; set; }

    public string? Mobile { get; set; }

    public string? Email { get; set; }

    public string? Pan { get; set; }

    public string? BankPoa { get; set; }

    public string? BuyerName { get; set; }

    public string? SellerName { get; set; }

    public int? EntityId { get; set; }

    public string? EntityName { get; set; }

    public string? EntityShortName { get; set; }

    public string? ClientName { get; set; }

    public string? ClientCode { get; set; }

    public string? SecurityName { get; set; }

    public int? MakerId { get; set; }

    public string? Status { get; set; }

    public bool? IsNdpms { get; set; }

    public bool? IsActive { get; set; }

    public bool? IsDeleted { get; set; }

    public DateTime? MakerTimeStamp { get; set; }

    public DateTime? TradeDate { get; set; }

    public DateTime? CreatedOn { get; set; }
}
