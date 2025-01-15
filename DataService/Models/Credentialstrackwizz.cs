using System;
using System.Collections.Generic;

namespace DataService.Models;

public partial class Credentialstrackwizz
{
    public int Id { get; set; }

    public int EntityId { get; set; }

    public string? Url { get; set; }

    public string? ApiToken { get; set; }

    public string? Cluster { get; set; }

    public string? Domain { get; set; }

    public string? SourceSystemName { get; set; }

    public bool? IsActive { get; set; }

    public DateTime? CreatedOn { get; set; }

    public DateTime? ModifiedOn { get; set; }
}
