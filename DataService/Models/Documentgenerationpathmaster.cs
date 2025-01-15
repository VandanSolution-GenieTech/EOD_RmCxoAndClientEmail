using System;
using System.Collections.Generic;

namespace DataService.Models;

public partial class Documentgenerationpathmaster
{
    public int Id { get; set; }

    public int? Productid { get; set; }

    public string? Pdffilepath { get; set; }

    public bool? Isactive { get; set; }
}
