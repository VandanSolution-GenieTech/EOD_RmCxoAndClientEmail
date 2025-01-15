using System;
using System.Collections.Generic;

namespace DataService.Models;

public partial class WsOrderpushdatum
{
    public int Id { get; set; }

    public string? BrokerCode { get; set; }

    public string? Remark { get; set; }

    public string? SecurityCode { get; set; }

    public string? Exchange { get; set; }

    public string? TransType { get; set; }

    public string? OrderDate { get; set; }

    public string? Quantity { get; set; }

    public string? BrokerAcId { get; set; }

    public string? Rate { get; set; }

    public string? Amount { get; set; }

    public string? Note2 { get; set; }

    public string? ClientId { get; set; }

    public string? AdvisedFlag { get; set; }

    public string? ModeFlag { get; set; }

    public string? Mfplatform { get; set; }

    public string? FullSell { get; set; }

    public string? SwitchIn { get; set; }

    public string? Cpcode { get; set; }

    public string? CommitmentAmount { get; set; }

    public string? Frequency { get; set; }

    public string? StartDate { get; set; }

    public string? EndDate { get; set; }

    public string? TotalInstallment { get; set; }

    public string? StartDay { get; set; }

    public string? SubTranType { get; set; }

    public string? MandateId { get; set; }
}
