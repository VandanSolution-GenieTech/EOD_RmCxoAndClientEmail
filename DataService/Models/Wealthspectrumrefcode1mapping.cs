using System;
using System.Collections.Generic;

namespace DataService.Models;

public partial class Wealthspectrumrefcode1mapping
{
    public int Id { get; set; }

    public int? ProductType { get; set; }

    public int? SubProductType { get; set; }

    public string? RefCode1 { get; set; }

    public string? OperationType { get; set; }

    public string? AccountingTxn { get; set; }

    public bool? IsActive { get; set; }

    public DateTime? CreatedOn { get; set; }

    public DateTime? ModifiedOn { get; set; }
}
