using System;
using System.Collections.Generic;

namespace DataService.Models;

public partial class Qctracker
{
    public int Id { get; set; }

    public int? Invid { get; set; }

    public int? Holderrankid { get; set; }

    public bool? Isdedupecheck { get; set; }

    public bool? Isemailverified { get; set; }

    public bool? Ismobileverified { get; set; }

    public bool? Ispep { get; set; }

    public bool? Ispanverified { get; set; }

    public bool? Isaadharverified { get; set; }

    public bool? Iskrafetch { get; set; }

    public bool? Isbankverified { get; set; }

    public bool? Isnammatchedwithkraadharpenny { get; set; }

    public bool? Isriskrating { get; set; }

    public string? Riskratingvalue { get; set; }

    public bool? Isipv { get; set; }

    public bool? Isphotomatched { get; set; }

    public bool? Isamldone { get; set; }

    public string? Amlstatus { get; set; }

    public string? Amllink { get; set; }

    public string? Amlrejectionmessage { get; set; }

    public int? Amlalertcount { get; set; }

    public bool? Isactive { get; set; }
}
