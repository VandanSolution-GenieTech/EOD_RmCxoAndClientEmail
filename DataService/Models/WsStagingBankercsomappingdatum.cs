using System;
using System.Collections.Generic;

namespace DataService.Models;

public partial class WsStagingBankercsomappingdatum
{
    public int Id { get; set; }

    public string? BankerCode { get; set; }

    public string? CsoCode { get; set; }

    public bool? Isactive { get; set; }

    public DateTime? Createdon { get; set; }
}
