using System;
using System.Collections.Generic;

namespace DataService.Models;

public partial class EsignPdfType
{
    public int Id { get; set; }

    public int PdfTypeId { get; set; }

    public string? PdfType { get; set; }

    public bool? IsActive { get; set; }

    public DateTime? CreatedOn { get; set; }

    public DateTime? ModifiedOn { get; set; }
}
