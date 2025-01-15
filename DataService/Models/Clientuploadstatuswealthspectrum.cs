using System;
using System.Collections.Generic;

namespace DataService.Models;

public partial class Clientuploadstatuswealthspectrum
{
    public int Id { get; set; }

    public int InvId { get; set; }

    public string? TransactionType { get; set; }

    public int? ModificationId { get; set; }

    public string? RefCode1 { get; set; }

    public bool Success { get; set; }

    public bool? ClientCreationSuccess { get; set; }

    public int? RefNumber { get; set; }

    public string? Request { get; set; }

    public string? Response { get; set; }

    public bool? IsActive { get; set; }

    public DateTime? CreatedOn { get; set; }

    public DateTime? ModifiedOn { get; set; }
}
