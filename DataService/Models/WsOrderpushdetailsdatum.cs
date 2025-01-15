using System;
using System.Collections.Generic;

namespace DataService.Models;

public partial class WsOrderpushdetailsdatum
{
    public int Id { get; set; }

    public int? Orderhistoryid { get; set; }

    public string? Ordertype { get; set; }

    public string? Brokercode { get; set; }

    public string? Remark { get; set; }

    public string? Securitycode { get; set; }

    public string? Exchange { get; set; }

    public string? Transtype { get; set; }

    public string? Orderdate { get; set; }

    public string? Quantity { get; set; }

    public string? Brokeracid { get; set; }

    public string? Rate { get; set; }

    public string? Amount { get; set; }

    public string? Note2 { get; set; }

    public string? Clientid { get; set; }

    public string? Advisedflag { get; set; }

    public string? Modeflag { get; set; }

    public string? Mfplatform { get; set; }

    public string? Fullsell { get; set; }

    public string? Switchin { get; set; }

    public string? Cpcode { get; set; }

    public string? Commitmentamount { get; set; }

    public string? Frequency { get; set; }

    public string? Startdate { get; set; }

    public string? Enddate { get; set; }

    public string? Totalinstallment { get; set; }

    public string? Startday { get; set; }

    public string? Subtranstype { get; set; }

    public string? Madateid { get; set; }

    public bool? Isactive { get; set; }

    public bool? Issent { get; set; }

    public DateTime? Createdon { get; set; }
}
