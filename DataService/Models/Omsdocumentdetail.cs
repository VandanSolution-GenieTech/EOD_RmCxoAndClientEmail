using System;
using System.Collections.Generic;

namespace DataService.Models;

public partial class Omsdocumentdetail
{
    public int Id { get; set; }

    public int Invid { get; set; }

    public int? Holderrankid { get; set; }

    public int? Documenttypeid { get; set; }

    public string? Documentexpirydate { get; set; }

    public string? Documentfilename { get; set; }

    public string? Documentfileextension { get; set; }

    public string? Documentfilepath { get; set; }

    public int? Pagescount { get; set; }

    public bool? Isactive { get; set; }

    public bool? Isdeleted { get; set; }

    public int? Createdby { get; set; }

    public DateTime? Createdon { get; set; }

    public int? Modifiedby { get; set; }

    public DateTime? Modifiedon { get; set; }

    public int? Orderhistoryid { get; set; }

    public string? Uploadername { get; set; }

    public string? Clientcode { get; set; }

    public string? Orderype { get; set; }
}
