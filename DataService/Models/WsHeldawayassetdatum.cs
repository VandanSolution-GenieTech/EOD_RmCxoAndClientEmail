using System;
using System.Collections.Generic;

namespace DataService.Models;

public partial class WsHeldawayassetdatum
{
    public string? DataType { get; set; }

    public long? ClientId { get; set; }

    public string? FundSymbolCode { get; set; }

    public string? SymbolName { get; set; }

    public string? RefCode1 { get; set; }

    public string? RefCode3 { get; set; }

    public string? RefCode4 { get; set; }

    public string? RefCode5 { get; set; }

    public string? ClientName { get; set; }

    public long? CommitmentAmount { get; set; }

    public string? ClientSymbolCode { get; set; }

    public string? Folio { get; set; }

    public string? BankAccountType { get; set; }

    public string? BankCode { get; set; }

    public string? BankAccountId { get; set; }

    public bool? Isactive { get; set; }
}
