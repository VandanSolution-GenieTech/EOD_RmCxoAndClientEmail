using System;
using System.Collections.Generic;

namespace DataService.Models;

public partial class Cdsluploadstatuslog
{
    public int Id { get; set; }

    public int InvId { get; set; }

    public string? TransactionType { get; set; }

    public int? ModificationId { get; set; }

    public string? BatchNumber { get; set; }

    public bool Success { get; set; }

    public string? BaseFileContent { get; set; }

    public string? Response { get; set; }

    public bool? IsActive { get; set; }

    public DateTime? CreatedOn { get; set; }

    public DateTime? ModifiedOn { get; set; }
}
