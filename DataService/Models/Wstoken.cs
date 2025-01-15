using System;
using System.Collections.Generic;

namespace DataService.Models;

public partial class Wstoken
{
    public int Id { get; set; }

    public string ApiKey { get; set; } = null!;

    public string Username { get; set; } = null!;

    public long? Userid { get; set; }

    public bool? Isactive { get; set; }

    public bool? Isdeleted { get; set; }

    public DateTime? Createdon { get; set; }

    public DateTime? Revokedon { get; set; }

    public virtual Wsusermaster UsernameNavigation { get; set; } = null!;
}
