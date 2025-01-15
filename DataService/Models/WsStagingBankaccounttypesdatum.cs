using System;
using System.Collections.Generic;

namespace DataService.Models;

public partial class WsStagingBankaccounttypesdatum
{
    public int Id { get; set; }

    public string? Accounttype { get; set; }

    public bool? Isactive { get; set; }

    public DateTime? CreatedOn { get; set; }
}
