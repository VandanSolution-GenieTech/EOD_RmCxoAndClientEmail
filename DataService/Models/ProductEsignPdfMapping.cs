using System;
using System.Collections.Generic;

namespace DataService.Models;

public partial class ProductEsignPdfMapping
{
    public int Id { get; set; }

    public int ProductId { get; set; }

    public int? SchemeType { get; set; }

    public int EntityId { get; set; }

    public int PdfTypeId { get; set; }

    public bool? IsActive { get; set; }

    public DateTime? CreatedOn { get; set; }

    public DateTime? ModifiedOn { get; set; }
}
