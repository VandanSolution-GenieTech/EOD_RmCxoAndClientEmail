using System;
using System.Collections.Generic;

namespace DataService.Models;

public partial class Ckyccodesmaster
{
    public int Id { get; set; }

    public int Imagecode { get; set; }

    public string? Description { get; set; }

    public string? Documentname { get; set; }

    public ulong? Isactive { get; set; }
}
