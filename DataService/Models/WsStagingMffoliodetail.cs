using System;
using System.Collections.Generic;

namespace DataService.Models;

public partial class WsStagingMffoliodetail
{
    public int Id { get; set; }

    public string? Clientid { get; set; }

    public string? Registrar { get; set; }

    public string? Registrarname { get; set; }

    public string? Amc { get; set; }

    public string? Amcname { get; set; }

    public string? Folio { get; set; }

    public string? Subfolio { get; set; }

    public string? Defaultamc { get; set; }

    public string? Folioactive { get; set; }

    public DateTime? CreatedOn { get; set; }

    public bool? Isactive { get; set; }
}
