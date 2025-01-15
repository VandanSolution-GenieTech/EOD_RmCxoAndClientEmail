using System;
using System.Collections.Generic;

namespace DataService.Models;

public partial class Credentialssignzy
{
    public int Id { get; set; }

    public int EntityId { get; set; }

    public string UserName { get; set; } = null!;

    public string Passwords { get; set; } = null!;

    public string PatronId { get; set; } = null!;

    public string? AuthorizationV2 { get; set; }

    public string? AuthorizationV3 { get; set; }

    public bool? IsActive { get; set; }

    public DateTime? CreatedOn { get; set; }

    public DateTime? ModifiedOn { get; set; }
}
