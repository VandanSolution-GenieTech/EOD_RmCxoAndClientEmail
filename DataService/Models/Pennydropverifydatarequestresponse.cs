using System;
using System.Collections.Generic;

namespace DataService.Models;

public partial class Pennydropverifydatarequestresponse
{
    public int Id { get; set; }

    public int Invid { get; set; }

    public string? Pennydroprequest { get; set; }

    public string? Peenydropresponse { get; set; }

    public DateTime? Timestamprequest { get; set; }

    public DateTime? Timestampresponse { get; set; }

    public ulong? IsActive { get; set; }

    public string? Isaccountactive { get; set; }

    public string? Reason { get; set; }

    public string? Namematchscore { get; set; }

    public string? BeneficiaryName { get; set; }
}
