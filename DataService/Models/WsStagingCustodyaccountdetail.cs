using System;
using System.Collections.Generic;

namespace DataService.Models;

public partial class WsStagingCustodyaccountdetail
{
    public int Id { get; set; }

    public string? Clientid { get; set; }

    public string? Depository { get; set; }

    public string? Despositoryname { get; set; }

    public string? Dpid { get; set; }

    public string? Dpname { get; set; }

    public string? Dpclientid { get; set; }

    public DateTime? CreatedOn { get; set; }

    public bool? Isactive { get; set; }
}
