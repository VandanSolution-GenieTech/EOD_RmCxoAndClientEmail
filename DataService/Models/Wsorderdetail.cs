using System;
using System.Collections.Generic;

namespace DataService.Models;

public partial class Wsorderdetail
{
    public int Id { get; set; }

    public string? Brokercode { get; set; }

    public string? Remark { get; set; }

    public string? Securitycode { get; set; }

    public string? Exchange { get; set; }

    public string? Transtype { get; set; }

    public DateOnly? Orderdate { get; set; }

    public decimal? Quantity { get; set; }

    public string? Brokeracid { get; set; }

    public decimal? Rate { get; set; }

    public decimal? Amount { get; set; }

    public string? Note2 { get; set; }

    public int? Clientid { get; set; }

    public string? Advisedflag { get; set; }

    public string? Modeflag { get; set; }

    public string? Mfplatform { get; set; }

    public string? Fullsell { get; set; }

    public string? Switchin { get; set; }

    public string? Cpcode { get; set; }

    public decimal? Commitmentamnt { get; set; }

    public string? Frequency { get; set; }

    public DateOnly? Startdate { get; set; }

    public DateOnly? Enddate { get; set; }

    public int? Totalinstallment { get; set; }

    public string? Startday { get; set; }

    public string? Subtranstype { get; set; }

    public string? Mandateid { get; set; }

    public DateTime? Createdon { get; set; }
}
