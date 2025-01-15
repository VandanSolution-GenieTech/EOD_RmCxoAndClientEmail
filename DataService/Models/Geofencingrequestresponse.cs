using System;
using System.Collections.Generic;

namespace DataService.Models;

public partial class Geofencingrequestresponse
{
    public int Uniquid { get; set; }

    public string? Ip { get; set; }

    public string? UserAgent { get; set; }

    public string? Browser { get; set; }

    public string? OperatingSystem { get; set; }

    public string? Device { get; set; }

    public string? Url { get; set; }

    public string? Country { get; set; }

    public string? PatronId { get; set; }

    public string? Id { get; set; }

    public string? State { get; set; }

    public string? StateCode { get; set; }

    public string? City { get; set; }

    public string? ZipCode { get; set; }

    public string? Timezone { get; set; }

    public string? Latitude { get; set; }

    public string? Longitude { get; set; }

    public string? Asn { get; set; }

    public bool? Riskip { get; set; }

    public bool? ValidUser { get; set; }

    public bool? Isactive { get; set; }

    public int? Invid { get; set; }

    public int? HolderRankId { get; set; }

    public DateTime? Timestamp { get; set; }
}
