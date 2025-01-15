using System;
using System.Collections.Generic;

namespace DataService.Models;

public partial class Omsmutualfundincomedetail
{
    public int Id { get; set; }

    public int? Orderhistoryid { get; set; }

    public string? UccCode { get; set; }

    public int? Scripid { get; set; }

    public string? TransactionTypeList { get; set; }

    public int? Amcid { get; set; }

    public string? Amcname { get; set; }

    public string? Isincode { get; set; }

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

    public int? MakerId { get; set; }

    public int? ApproverId { get; set; }

    public string? Reason { get; set; }

    public bool? IsActive { get; set; }

    public bool? IsDeleted { get; set; }

    public DateTime? TradeDate { get; set; }

    public DateTime? Makertimestamp { get; set; }

    public DateTime? Approvertimestamp { get; set; }

    public DateTime? CreatedOn { get; set; }
}
