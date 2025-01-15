using System;
using System.Collections.Generic;

namespace DataService.Models;

public partial class Onbinvestorbankdetail
{
    public int Id { get; set; }

    public int Invid { get; set; }

    public int? AccountTypeId { get; set; }

    public string? AccountNo { get; set; }

    public int? BranchId { get; set; }

    public bool? IsPaymentDetail { get; set; }

    public string? ModeofPayment { get; set; }

    public string? ChequeNo { get; set; }

    public string? ChequeDate { get; set; }

    public string? ChequeBankName { get; set; }

    public bool? IsPrimary { get; set; }

    public bool? IsPennyDropVerify { get; set; }

    public bool? IsBankPoa { get; set; }

    public string? NameMatch { get; set; }

    public decimal? NameMatchScore { get; set; }

    public string? NameAsPerBank { get; set; }

    public bool? NeedCheckerApproval { get; set; }

    public string? ApprovalStatus { get; set; }

    public int? ApprovedBy { get; set; }

    public string? Comment { get; set; }

    public DateTime? ApprovedOn { get; set; }

    public bool? IsActive { get; set; }

    public bool? IsDeleted { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }
}
