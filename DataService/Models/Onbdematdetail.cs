using System;
using System.Collections.Generic;

namespace DataService.Models;

public partial class Onbdematdetail
{
    public int Id { get; set; }

    public int Invid { get; set; }

    public string? DematNo { get; set; }

    public string? Peprep { get; set; }

    public string? Smsalert { get; set; }

    public string? PanNo { get; set; }

    public string? AadharNo { get; set; }

    public string? Occupation { get; set; }

    public string? MobileNo { get; set; }

    public string? IncomeperAnnum { get; set; }

    public string? Pmladetails { get; set; }

    public string? Smsemailreceiveyn { get; set; }

    public string? Smsemailreceivevia { get; set; }

    public string? Smsmobile { get; set; }

    public string? Smsemail { get; set; }

    public int? HolderIndex { get; set; }

    public int? IsActive { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public bool IsDeleted { get; set; }
}
