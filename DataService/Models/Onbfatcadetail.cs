using System;
using System.Collections.Generic;

namespace DataService.Models;

public partial class Onbfatcadetail
{
    public int Id { get; set; }

    public int Invid { get; set; }

    public int? HolderRankId { get; set; }

    public int? SerialNo { get; set; }

    public string? TaxCountry { get; set; }

    public string? TaxIdentificationType { get; set; }

    public string? TaxIdentificationNumber { get; set; }

    public bool? IsActive { get; set; }

    public bool? IsDeleted { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }
}
