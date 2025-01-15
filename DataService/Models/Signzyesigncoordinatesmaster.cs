using System;
using System.Collections.Generic;

namespace DataService.Models;

public partial class Signzyesigncoordinatesmaster
{
    public int Id { get; set; }

    public int? ProductId { get; set; }

    public int ClientTypeId { get; set; }

    public int PdfType { get; set; }

    public int? HolderCount { get; set; }

    public bool IsAdditionalSigner { get; set; }

    public int? AdditionalSignerRank { get; set; }

    public int? HolderRankId { get; set; }

    public int? PageNumber { get; set; }

    public string? SignaturePosition { get; set; }

    public int? Xcoordinate { get; set; }

    public int? Ycoordinate { get; set; }

    public bool? IsActive { get; set; }
}
