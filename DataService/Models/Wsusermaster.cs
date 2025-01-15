using System;
using System.Collections.Generic;

namespace DataService.Models;

public partial class Wsusermaster
{
    public int Id { get; set; }

    public string Username { get; set; } = null!;

    public bool? Isactive { get; set; }

    public bool? Isdeleted { get; set; }

    public DateTime? Createdon { get; set; }

    public string? Createdby { get; set; }

    public DateTime? Updatedon { get; set; }

    public string? Updatedby { get; set; }

    public virtual ICollection<Wstoken> Wstokens { get; set; } = new List<Wstoken>();
}
