using System;
using System.Collections.Generic;

namespace DataService.Models;

public partial class WsApiurl
{
    public int Id { get; set; }

    public string ApiName { get; set; } = null!;

    public string ApiUrl { get; set; } = null!;

    public bool? IsActive { get; set; }

    public bool IsEod { get; set; }

    public DateTime? CreatedOn { get; set; }
}
