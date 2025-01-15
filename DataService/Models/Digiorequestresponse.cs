using System;
using System.Collections.Generic;

namespace DataService.Models;

public partial class Digiorequestresponse
{
    public int Id { get; set; }

    public int? InvId { get; set; }

    public string? Request { get; set; }

    public DateTime? Requesttimestamp { get; set; }

    public string? Digioid { get; set; }

    public string? Signers { get; set; }

    public int? Expireindays { get; set; }

    public string? Notifysigners { get; set; }

    public string? Filname { get; set; }

    public string? Signcordinates { get; set; }

    public bool? Iserror { get; set; }

    public int? Holderrankid { get; set; }

    public int? Pdftype { get; set; }

    public int? Modificationid { get; set; }
}
