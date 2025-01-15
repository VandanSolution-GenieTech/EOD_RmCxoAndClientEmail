using System;
using System.Collections.Generic;

namespace DataService.Models;

public partial class PdffixedImage
{
    public int IncrementId { get; set; }

    public string SignImg { get; set; } = null!;

    public string PhotoImg { get; set; } = null!;

    public string LogoImg { get; set; } = null!;

    public DateTime? TimeStamp { get; set; }
}
