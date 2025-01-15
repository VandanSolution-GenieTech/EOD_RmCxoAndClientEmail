using System;
using System.Collections.Generic;

namespace DataService.Models;

public partial class Credentialsdigio
{
    public int Id { get; set; }

    public int EntityId { get; set; }

    public string ClientId { get; set; } = null!;

    public string ClientSecret { get; set; } = null!;

    public int? ExpiryDays { get; set; }

    public bool? IsActive { get; set; }

    public DateTime? CreatedOn { get; set; }

    public DateTime? ModifiedOn { get; set; }
}
