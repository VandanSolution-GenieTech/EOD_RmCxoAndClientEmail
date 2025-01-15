using System;
using System.Collections.Generic;

namespace DataService.Models;

public partial class OmspaymentapprovalequestDetail
{
    public int Id { get; set; }

    public int? PaymentTransferrequestId { get; set; }

    public string? Utrno { get; set; }

    public decimal? Amount { get; set; }

    public bool? Isactive { get; set; }

    public virtual Omspaymentapprovalrequest? PaymentTransferrequest { get; set; }
}
