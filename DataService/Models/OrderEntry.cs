using System;
using System.Collections.Generic;

namespace DataService.Models;

public partial class OrderEntry
{
    public int Id { get; set; }

    public string? Status { get; set; }

    public string? OrderId { get; set; }

    public string? AnotherId { get; set; }

    public string? YetAnotherId { get; set; }

    public string? SomeCode { get; set; }

    public string? ClientCode { get; set; }

    public string? ConfirmationMessage { get; set; }

    public DateTime? ConfirmationTime { get; set; }

    public string? EntryBy { get; set; }

    public string? OrderNo { get; set; }

    public string? Scheme { get; set; }
}
