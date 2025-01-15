using System;
using System.Collections.Generic;

namespace DataService.Models;

public partial class VwInvestorDetail
{
    public int InvId { get; set; }

    public string ClientType { get; set; } = null!;

    public string? FirstName { get; set; }

    public string? MiddleName { get; set; }

    public string? LastName { get; set; }

    public string Pan { get; set; } = null!;

    public DateTime? Dob { get; set; }

    public string Status { get; set; } = null!;

    public string? Rmname { get; set; }

    public string? Distributor { get; set; }

    public string? ProductName { get; set; }

    public string? Ucccode { get; set; }

    public string? BankerName { get; set; }

    public string IsExpress { get; set; } = null!;

    public string IsPhysicalDigital { get; set; } = null!;

    public DateTime? CreatedOn { get; set; }

    public DateTime? ModifiedOn { get; set; }
}
