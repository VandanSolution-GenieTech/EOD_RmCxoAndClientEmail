using System;
using System.Collections.Generic;

namespace DataService.Models;

public partial class Signzyesignrequestresponse
{
    public int Id { get; set; }

    public int? InvId { get; set; }

    public string? Request { get; set; }

    public DateTime? RequestTimestamp { get; set; }

    public string? Response { get; set; }

    public DateTime? ResponseTimestamp { get; set; }

    public string? ContractId { get; set; }

    public int? ContractTtl { get; set; }

    public string? FilName { get; set; }

    public string? SignerLinkDetails { get; set; }

    public bool? Success { get; set; }

    public int? HolderRankId { get; set; }

    public int? PdfType { get; set; }

    public int? ModificationId { get; set; }

    public bool? IsActive { get; set; }
}
