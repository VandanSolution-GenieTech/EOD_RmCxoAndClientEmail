using System;
using System.Collections.Generic;

namespace DataService.Models;

public partial class Esignadditionaldetail
{
    public int Id { get; set; }

    public int ProductId { get; set; }

    public int DistributorId { get; set; }

    public int PdfTypeId { get; set; }

    public int? SequenceNo { get; set; }

    public string? SignerName { get; set; }

    public string? SignerRole { get; set; }

    public string? EmailId { get; set; }

    public string? MobileNo { get; set; }

    public string? EsignPreference { get; set; }

    public bool? IsActive { get; set; }

    public DateTime? ActiveFrom { get; set; }

    public DateTime? ActiveTo { get; set; }

    public DateTime? CreatedOn { get; set; }

    public DateTime? ModifiedOn { get; set; }
}
