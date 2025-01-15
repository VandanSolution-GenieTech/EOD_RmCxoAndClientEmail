using System;
using System.Collections.Generic;

namespace DataService.Models;

public partial class MfTransactionPurchaseRedemption
{
    public int Id { get; set; }

    public int OrderHistoryId { get; set; }

    public string? Lob { get; set; }

    public string ReferenceNumber { get; set; } = null!;

    public DateTime TradeDate { get; set; }

    public string TransactionCode { get; set; } = null!;

    public string TransactionNumber { get; set; } = null!;

    public long? OrderId { get; set; }

    public long UserId { get; set; }

    public string MemberId { get; set; } = null!;

    public string ClientCode { get; set; } = null!;

    public string SchemeCd { get; set; } = null!;

    public string BuySell { get; set; } = null!;

    public string BuySellType { get; set; } = null!;

    public string Dptxn { get; set; } = null!;

    public double? Amount { get; set; }

    public double? Qty { get; set; }

    public string AllRedeem { get; set; } = null!;

    public string? FolioNo { get; set; }

    public string? Remarks { get; set; }

    public string Kycstatus { get; set; } = null!;

    public string? RefNo { get; set; }

    public string? SubBrCode { get; set; }

    public string Euin { get; set; } = null!;

    public string Euinflag { get; set; } = null!;

    public string MinRedeem { get; set; } = null!;

    public string Dpc { get; set; } = null!;

    public string? Ipadd { get; set; }

    public string Password { get; set; } = null!;

    public string PassKey { get; set; } = null!;

    public string? Param1 { get; set; }

    public string? Param2 { get; set; }

    public string? Param3 { get; set; }

    public string? MobileNo { get; set; }

    public string? EmailId { get; set; }

    public string? MandateId { get; set; }

    public DateTime? CreatedOn { get; set; }

    public string? Orderby { get; set; }

    public bool? IsSent { get; set; }

    public string? WsAccountCode { get; set; }

    public int? EnntityId { get; set; }
}
