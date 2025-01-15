using System;
using System.Collections.Generic;

namespace DataService.Models;

public partial class Productapivendormapping
{
    public int Id { get; set; }

    public int ProductId { get; set; }

    public int ApiVendorId { get; set; }

    public bool? IsActive { get; set; }

    public DateTime? CreatedOn { get; set; }

    public DateTime? ModifiedOn { get; set; }
}
