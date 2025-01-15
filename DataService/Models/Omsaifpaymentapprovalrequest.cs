﻿using System;
using System.Collections.Generic;

namespace DataService.Models;

public partial class Omsaifpaymentapprovalrequest
{
    public int Id { get; set; }

    public int? Invid { get; set; }

    public int? Holderrankid { get; set; }

    public int? Makerid { get; set; }

    public DateTime? Makertimestamp { get; set; }

    public int? Approverid { get; set; }

    public DateTime? Approvertimestamp { get; set; }

    public decimal? Totalamount { get; set; }

    public string? Remark { get; set; }

    public string? Status { get; set; }

    public bool? Isactive { get; set; }

    public int? Instrumentsid { get; set; }

    public string? Calltype { get; set; }

    public int? Orderhistoryid { get; set; }

    public virtual ICollection<OmsaifpaymentapprovalequestDetail> OmsaifpaymentapprovalequestDetails { get; set; } = new List<OmsaifpaymentapprovalequestDetail>();
}