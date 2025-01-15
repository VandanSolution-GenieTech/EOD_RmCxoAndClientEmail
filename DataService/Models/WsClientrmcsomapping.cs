using System;
using System.Collections.Generic;

namespace DataService.Models;

public partial class WsClientrmcsomapping
{
    public int Id { get; set; }

    public int? Clientid { get; set; }

    public string? Pannumber { get; set; }

    public string? Acctype { get; set; }

    public string? Mapinid { get; set; }

    public string? BankerEmpId { get; set; }

    public string? BankerName { get; set; }

    public string? BankerEmail { get; set; }

    public long? BankerMobile { get; set; }

    public int? CsoempId { get; set; }

    public string? Csoname { get; set; }

    public string? Csoemail { get; set; }

    public long? Csomobile { get; set; }

    public bool? IsActive { get; set; }
}
