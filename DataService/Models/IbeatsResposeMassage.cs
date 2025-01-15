using System;
using System.Collections.Generic;

namespace DataService.Models;

public partial class IbeatsResposeMassage
{
    public int Id { get; set; }

    public int? Invid { get; set; }

    public bool? Success { get; set; }

    public string? AccountCode { get; set; }

    public long? KycReqNo { get; set; }

    public DateTime? CreatedOn { get; set; }

    public bool? IsActive { get; set; }
}
