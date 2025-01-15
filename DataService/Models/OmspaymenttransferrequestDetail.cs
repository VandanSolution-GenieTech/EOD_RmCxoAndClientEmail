using System;
using System.Collections.Generic;

namespace DataService.Models;

public partial class OmspaymenttransferrequestDetail
{
    public int Id { get; set; }

    public int? PaymentTransferrequestId { get; set; }

    public string? Utrno { get; set; }

    public decimal? Amount { get; set; }

    public virtual Omspaymenttransferrequest? PaymentTransferrequest { get; set; }
}
