using System;
using System.Collections.Generic;

namespace DataService.Models;

public partial class Omsbuysellorderdashboardatum
{
    public int Id { get; set; }

    public int? Productid { get; set; }

    public int? Invid { get; set; }

    public int? Bankid { get; set; }

    public int? Dpid { get; set; }

    public string? Ordertype { get; set; }

    public int? Scripid { get; set; }

    public string? Isincode { get; set; }

    public string? Buyselltype { get; set; }

    public int? Makerid { get; set; }

    public DateTime? Makertimestamp { get; set; }

    public int? Approverid { get; set; }

    public DateTime? Approvertimestamp { get; set; }

    public DateTime? Tradedate { get; set; }

    public DateTime? Tradetime { get; set; }

    public string? Platform { get; set; }

    public string? Referencenumber { get; set; }

    public int? Entityid { get; set; }

    public string? Clientname { get; set; }

    public string? Clientcode { get; set; }

    public string? Securityname { get; set; }

    public bool? Isactiontakenfrombondteam { get; set; }

    public bool? Isfmapprovalpending { get; set; }

    public string? Mobile { get; set; }

    public string? Email { get; set; }

    public string? Pan { get; set; }

    public bool? Isndpms { get; set; }

    public bool? Isactive { get; set; }
}
