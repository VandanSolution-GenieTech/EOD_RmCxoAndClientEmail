using System;
using System.Collections.Generic;

namespace DataService.Models;

public partial class WsStagingBankaccountdetail
{
    public int Id { get; set; }

    public string? Clientid { get; set; }

    public string? Bankcode { get; set; }

    public string? Bankname { get; set; }

    public string? Bankaccount { get; set; }

    public string? Bankactype { get; set; }

    public string? Cashsymbol { get; set; }

    public string? BankBranch { get; set; }

    public DateTime? CreatedOn { get; set; }

    public bool? Isactive { get; set; }
}
