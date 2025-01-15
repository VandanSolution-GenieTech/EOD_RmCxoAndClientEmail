using System;
using System.Collections.Generic;

namespace DataService.Models;

public partial class VwStageMi
{
    public string FormNo { get; set; } = null!;

    public string? InvestorName { get; set; }

    public string InvestorPan { get; set; } = null!;

    public string InvestorType { get; set; } = null!;

    public decimal? InvestmentCorpus { get; set; }

    public string? Cxo { get; set; }

    public string? Banker { get; set; }

    public string? Lob { get; set; }

    public string? AccountType { get; set; }

    public string ModeOfApplication { get; set; } = null!;

    public string? Cvlkrastatus { get; set; }

    public string CvlkradatePush { get; set; } = null!;

    public string CvlkradateReverse { get; set; } = null!;

    public string BankPoageneratedDate { get; set; } = null!;

    public string BankPoawelcomeLetter { get; set; } = null!;

    public string ClassDppush { get; set; } = null!;

    public string ClassDpreverse { get; set; } = null!;

    public string ClassTradingPush { get; set; } = null!;

    public string ClassTradingReverse { get; set; } = null!;

    public string CdslpushDate { get; set; } = null!;

    public string CdslreverseDate { get; set; } = null!;

    public string Bsecmpush { get; set; } = null!;

    public string Bsecmreverse { get; set; } = null!;

    public string Nsecmpush { get; set; } = null!;

    public string Nsecmreverse { get; set; } = null!;

    public string? Nseucc { get; set; }

    public string Nsesegment { get; set; } = null!;

    public string? Bseucc { get; set; }

    public string Bsesegment { get; set; } = null!;

    public string BsestarNwmDemat { get; set; } = null!;

    public string BsestarDematReverse { get; set; } = null!;

    public string BsestarNwmPhysical { get; set; } = null!;

    public string BsestarPhysicalReverse { get; set; } = null!;

    public string BsestarNwp { get; set; } = null!;

    public string WealthSpectrumPush { get; set; } = null!;

    public string WealthSpectrumReverse { get; set; } = null!;

    public string ReadyToTrade { get; set; } = null!;

    public string Icicibank { get; set; } = null!;

    public string WltoInvestor { get; set; } = null!;

    public string? Ckyc { get; set; }

    public string Tat { get; set; } = null!;
}
