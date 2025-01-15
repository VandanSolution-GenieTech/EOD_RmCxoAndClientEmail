using System;
using System.Collections.Generic;

namespace DataService.Models;

public partial class Esignattachmentcoordinate
{
    public int Id { get; set; }

    public int ProductId { get; set; }

    public int ClientType { get; set; }

    public int PdfType { get; set; }

    public int HolderRankId { get; set; }

    public decimal? Llx { get; set; }

    public decimal? Lly { get; set; }

    public decimal? Urx { get; set; }

    public decimal? Ury { get; set; }

    public bool? IsActive { get; set; }
}
