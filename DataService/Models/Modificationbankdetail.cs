using System;
using System.Collections.Generic;

namespace DataService.Models;

public partial class Modificationbankdetail
{
    public int Id { get; set; }

    public int ModificationId { get; set; }

    public bool? IsModified { get; set; }

    public int? BankDetailsId { get; set; }

    public int? AccountTypeId { get; set; }

    public string? AccountNo { get; set; }

    public int? BranchId { get; set; }

    public bool? IsPrimary { get; set; }

    public bool? PennyDropVerified { get; set; }

    public bool? MarkedForDelete { get; set; }

    public DateTime? CreatedOn { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public bool? IsActive { get; set; }
}
