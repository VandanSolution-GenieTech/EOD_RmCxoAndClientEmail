using System;
using System.Collections.Generic;

namespace DataService.Models;

public partial class Readyfortradestatus
{
    public int Id { get; set; }

    public int InvId { get; set; }

    public bool? BseStatus { get; set; }

    public DateTime? BseStatusDate { get; set; }

    public bool? BseStarStatus { get; set; }

    public DateTime? BseStarStatusDate { get; set; }

    public bool? NseStatus { get; set; }

    public DateTime? NseStatusDate { get; set; }

    public bool? CdslStatus { get; set; }

    public DateTime? CdslStatusDate { get; set; }

    public bool? ClassStatus { get; set; }

    public DateTime? ClassStatusDate { get; set; }

    public bool? ClassDpStatus { get; set; }

    public DateTime? ClassDpStatusDate { get; set; }

    public bool? WealthSpectrumStatus { get; set; }

    public DateTime? WealthSpectrumStatusDate { get; set; }

    public bool? IbeatsStatus { get; set; }

    public DateTime? IbeatsStatusDate { get; set; }

    public bool? MailSendStatus { get; set; }

    public DateTime? MailSentOn { get; set; }

    public bool? IsActive { get; set; }

    public DateTime? CreatedOn { get; set; }

    public DateTime? ModifiedOn { get; set; }
}
