using System;
using System.Collections.Generic;

namespace DataService.Models;

public partial class Onbformlog
{
    public int Id { get; set; }

    public int InvId { get; set; }

    public int LogTypeId { get; set; }

    public int LogTypeValue { get; set; }

    public int UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }
}
