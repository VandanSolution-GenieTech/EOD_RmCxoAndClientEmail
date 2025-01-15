using System;
using System.Collections.Generic;

namespace DataService.Models;

public partial class Wsmfcountrycode
{
    public int Id { get; set; }

    public string? Code { get; set; }

    public string? CountryName { get; set; }

    public DateTime? CreatedOn { get; set; }
}
