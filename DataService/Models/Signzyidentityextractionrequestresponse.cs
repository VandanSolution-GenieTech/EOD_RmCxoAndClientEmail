using System;
using System.Collections.Generic;

namespace DataService.Models;

public partial class Signzyidentityextractionrequestresponse
{
    public int Id { get; set; }

    public int? Invid { get; set; }

    public int? Holderrankid { get; set; }

    public string? Documenttype { get; set; }

    public string? Request { get; set; }

    public DateTime? Requesttimestamp { get; set; }

    public string? Response { get; set; }

    public DateTime? Responsetimestamp { get; set; }

    public string? Name { get; set; }

    public string? Pan { get; set; }

    public string? Aadhaarnumber { get; set; }

    public string? Dob { get; set; }

    public string? Accountnumber { get; set; }

    public string? Ifsccode { get; set; }

    public string? Accounttype { get; set; }

    public string? Itemid { get; set; }

    public string? Accesstoken { get; set; }

    public string? Imageurl { get; set; }

    public ulong? Isactive { get; set; }

    public string? Branch { get; set; }

    public string? IsMasked { get; set; }

    public string? MaskedImage { get; set; }
}
