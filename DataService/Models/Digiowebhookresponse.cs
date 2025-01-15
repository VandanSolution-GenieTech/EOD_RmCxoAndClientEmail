using System;
using System.Collections.Generic;

namespace DataService.Models;

public partial class Digiowebhookresponse
{
    public string Id { get; set; } = null!;

    public string? Event { get; set; }

    public string? CreatedAt { get; set; }

    public string? Payload { get; set; }

    public string? Entities { get; set; }

    public string? DigioId { get; set; }

    public string? FileName { get; set; }

    public string? AgreementStatus { get; set; }

    public string? LastSignedBy { get; set; }

    public bool? HasAllSigned { get; set; }

    public string? SignatureType1 { get; set; }

    public string? Status1 { get; set; }

    public string? Name1 { get; set; }

    public string? Identifier1 { get; set; }

    public string? UpdatedAt1 { get; set; }

    public string? SignatureType2 { get; set; }

    public string? Status2 { get; set; }

    public string? Name2 { get; set; }

    public string? Identifier2 { get; set; }

    public string? UpdatedAt2 { get; set; }

    public string? SignatureType3 { get; set; }

    public string? Stataus3 { get; set; }

    public string? Name3 { get; set; }

    public string? Identifier3 { get; set; }

    public string? UpdatedAt3 { get; set; }
}
