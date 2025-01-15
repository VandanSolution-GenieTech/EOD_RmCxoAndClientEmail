using System;
using System.Collections.Generic;

namespace DataService.Models;

public partial class Credentialssmtpmailer
{
    public int Id { get; set; }

    public int EntityId { get; set; }

    public string ServerAddress { get; set; } = null!;

    public string SmtpPort { get; set; } = null!;

    public string UserName { get; set; } = null!;

    public string Passwords { get; set; } = null!;

    public string SenderEmailHandle { get; set; } = null!;

    public string? DisplayName { get; set; }

    public string? FormAddress { get; set; }

    public bool? IsActive { get; set; }

    public DateTime? CreatedOn { get; set; }

    public DateTime? ModifiedOn { get; set; }
}
