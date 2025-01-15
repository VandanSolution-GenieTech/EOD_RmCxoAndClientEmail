using System;
using System.Collections.Generic;

namespace DataService.Models;

public partial class IbeatsPoaGpaBpaFlagsMapping
{
    public int Id { get; set; }

    public int ProductId { get; set; }

    public string PoaGpaBpaFlag { get; set; } = null!;

    public bool IsActive { get; set; }

    public DateTime? CreatedOn { get; set; }

    public DateTime? ModifiedOn { get; set; }
}
