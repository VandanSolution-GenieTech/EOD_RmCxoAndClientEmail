using System;
using System.Collections.Generic;

namespace DataService.Models;

public partial class WsBankercsomappingdatum
{
    public string? BankerCode { get; set; }

    public string? CsoCode { get; set; }

    public bool? Isactive { get; set; }
}
