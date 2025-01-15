using System;
using System.Collections.Generic;

namespace DataService.Models;

public partial class Digioestamppaper
{
    public int Id { get; set; }

    public int ProductId { get; set; }

    public int? PdfType { get; set; }

    public string EstampTag { get; set; } = null!;

    public int Quantity { get; set; }

    public string SignOnPage { get; set; } = null!;

    public string? NoteContent { get; set; }

    public string NoteOnPage { get; set; } = null!;

    public bool? IsActive { get; set; }

    public DateTime? CreatedOn { get; set; }

    public DateTime? ModifiedOn { get; set; }
}
