using System;
using System.Collections.Generic;

namespace DataService.Models;

public partial class Omsdownloadreportshistory
{
    public int Id { get; set; }

    public int? Createdby { get; set; }

    public DateTime? Createdon { get; set; }

    public string? Searchby { get; set; }

    public DateTime? Fromdate { get; set; }

    public DateTime? Todate { get; set; }

    public string? Productype { get; set; }

    public string? Isin { get; set; }

    public string? Scripname { get; set; }

    public string? Clientname { get; set; }

    public string? Platform { get; set; }

    public string? Tradestatus { get; set; }

    public string? Formattype { get; set; }

    public bool? Isactive { get; set; }

    public bool? Isdeleted { get; set; }
}
