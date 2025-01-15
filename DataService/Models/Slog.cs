using System;
using System.Collections.Generic;

namespace DataService.Models;

public partial class Slog
{
    public int Id { get; set; }

    public string ErrorString { get; set; } = null!;

    public DateTime? Dt { get; set; }
}
