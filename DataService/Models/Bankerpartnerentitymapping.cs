using System;
using System.Collections.Generic;

namespace DataService.Models;

public partial class Bankerpartnerentitymapping
{
    public int Id { get; set; }

    public int BankerId { get; set; }

    public int PartnerEntityId { get; set; }

    public bool? IsActive { get; set; }

    public DateTime? CreatedOn { get; set; }

    public DateTime? ModifiedOn { get; set; }
}
