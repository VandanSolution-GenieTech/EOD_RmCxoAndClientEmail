using System;
using System.Collections.Generic;

namespace DataService.Models;

public partial class Omsinstrumentmaster
{
    public int Id { get; set; }

    public string? Instrumentname { get; set; }

    public string? Instrumentshortname { get; set; }

    public string? Details { get; set; }

    public string? Pricesource { get; set; }

    public bool? Isclientconcent { get; set; }

    public bool? Ispricerange { get; set; }

    public bool? Isbuyerallocation { get; set; }

    public bool? Status { get; set; }

    public bool? Addedby { get; set; }

    public DateTime? Addedon { get; set; }

    public bool? Modifyby { get; set; }

    public DateTime? Modifyon { get; set; }

    public string? Category { get; set; }

    public bool? Isactive { get; set; }
}
