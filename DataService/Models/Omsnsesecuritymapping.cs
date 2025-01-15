using System;
using System.Collections.Generic;

namespace DataService.Models;

public partial class Omsnsesecuritymapping
{
    public int Id { get; set; }

    public int Scriptid { get; set; }

    public bool? Isactive { get; set; }

    public DateTime? CreatedOn { get; set; }
}
