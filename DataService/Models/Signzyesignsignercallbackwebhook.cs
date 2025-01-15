using System;
using System.Collections.Generic;

namespace DataService.Models;

public partial class Signzyesignsignercallbackwebhook
{
    public int Id { get; set; }

    public string? ContractId { get; set; }

    public string? SignerName { get; set; }

    public string? SignerEmail { get; set; }

    public string? SignerMobile { get; set; }

    public string? SignerId { get; set; }

    public DateTime? ContractLastSignTime { get; set; }

    public string? Status { get; set; }

    public string? ErrorMessage { get; set; }

    public string? SignerIp { get; set; }

    public DateTime? CreatedOn { get; set; }

    public string? CallbackRequest { get; set; }
}
