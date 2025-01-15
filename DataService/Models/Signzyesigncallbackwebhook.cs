using System;
using System.Collections.Generic;

namespace DataService.Models;

public partial class Signzyesigncallbackwebhook
{
    public int Id { get; set; }

    public string? ContractId { get; set; }

    public string? ContractName { get; set; }

    public bool? IsCompleted { get; set; }

    public string? FinalSignedContract { get; set; }

    public string? AuditCertificateUrl { get; set; }

    public string? CallbackRequest { get; set; }

    public DateTime? CreatedOn { get; set; }
}
