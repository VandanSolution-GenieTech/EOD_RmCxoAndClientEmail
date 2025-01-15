using System;
using System.Collections.Generic;

namespace DataService.Models;

public partial class Kracountrycodemaster
{
    public int Id { get; set; }

    public int? CountryId { get; set; }

    public string? CvlCountryId { get; set; }

    public string? CountryCode { get; set; }

    public bool? IsActive { get; set; }

    public DateTime? CreatedOn { get; set; }

    public DateTime? ModifiedOn { get; set; }
}
