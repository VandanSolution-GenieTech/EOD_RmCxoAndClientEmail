using System;
using System.Collections.Generic;

namespace DataService.Models;

public partial class Credentialsbsestar
{
    public int Id { get; set; }

    public int? EntityId { get; set; }

    public string? UserId { get; set; }

    public string? MemberCode { get; set; }

    public string? Password { get; set; }

    public string? PassKey { get; set; }

    public bool? IsActive { get; set; }

    public DateTime? CreatedOn { get; set; }

    public DateTime? ModifiedOn { get; set; }
}
