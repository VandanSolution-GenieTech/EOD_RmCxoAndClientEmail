using System;
using System.Collections.Generic;

namespace DataService.Models;

public partial class WsStagingClientbankermappingdatum
{
    public int Id { get; set; }

    public string? WswAccountCode { get; set; }

    public string? BankerCode { get; set; }

    public string? Pan { get; set; }

    public string? MobileNo { get; set; }

    public string? EmailId { get; set; }

    public bool? Isactive { get; set; }

    public DateTime? Createdon { get; set; }
}
