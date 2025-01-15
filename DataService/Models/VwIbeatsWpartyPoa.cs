using System;
using System.Collections.Generic;

namespace DataService.Models;

public partial class VwIbeatsWpartyPoa
{
    public int InvId { get; set; }

    public string? FormNo { get; set; }

    public string? AccountCode { get; set; }

    public int Products { get; set; }

    public int EditId { get; set; }

    public DateTime EditDtm { get; set; }

    public string Poaid { get; set; } = null!;

    public int? HolderIndicator { get; set; }

    public string Poatype { get; set; } = null!;

    public int SignatureFileFlag { get; set; }

    public string PoamasterPoaid { get; set; } = null!;

    public string? PoaregistrarNo { get; set; }

    public int PoatoOperateAc { get; set; }

    public DateOnly PoastartDate { get; set; }

    public DateOnly? PoaendDate { get; set; }

    public string PoacacharFld { get; set; } = null!;

    public string PoagpaorBpaflag { get; set; } = null!;

    public string Dpid { get; set; } = null!;

    public string DpclntId { get; set; } = null!;

    public string PoatypeFlag { get; set; } = null!;

    public ulong PoasrNo { get; set; }

    public int Cbecode { get; set; }

    public string PoatrxTypeCdsl { get; set; } = null!;
}
