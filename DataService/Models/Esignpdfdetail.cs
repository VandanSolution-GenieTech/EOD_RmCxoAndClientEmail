using System;
using System.Collections.Generic;

namespace DataService.Models;

public partial class Esignpdfdetail
{
    public int Id { get; set; }

    public int ProductId { get; set; }

    public int ClientType { get; set; }

    public int PdfType { get; set; }

    public int? HolderCount { get; set; }

    public int PdfFixedPages { get; set; }

    public bool? IsActive { get; set; }
}
