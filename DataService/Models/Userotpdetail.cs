using System;
using System.Collections.Generic;

namespace DataService.Models;

public partial class Userotpdetail
{
    public int Id { get; set; }

    public int UserId { get; set; }

    public long RandomOtpnumber { get; set; }

    public string Token { get; set; } = null!;

    public bool IsActive { get; set; }

    public DateTime? GeneratedDate { get; set; }
}
