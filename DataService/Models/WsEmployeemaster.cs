using System;
using System.Collections.Generic;

namespace DataService.Models;

public partial class WsEmployeemaster
{
    public int Id { get; set; }

    public string EmpCode { get; set; } = null!;

    public string? Name { get; set; }

    public string? Doj { get; set; }

    public string? ResignationDate { get; set; }

    public string? CategoryId { get; set; }

    public string? CategoryName { get; set; }

    public string? ChannelId { get; set; }

    public string? ChannelName { get; set; }

    public string? RcaCode { get; set; }

    public string? RoleId { get; set; }

    public string? Designation { get; set; }

    public string? Department { get; set; }

    public string? LobId { get; set; }

    public string? LobName { get; set; }

    public string? SublobId { get; set; }

    public string? SublobName { get; set; }

    public string? Email { get; set; }

    public string? Mobile { get; set; }

    public string? AlternateMobile { get; set; }

    public string? Landline { get; set; }

    public string? ExtentCode { get; set; }

    public string? LeftExtent { get; set; }

    public string? RightExtent { get; set; }

    public string? DataSourceId { get; set; }

    public string? IsActive { get; set; }

    public string? IsDeleted { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public DateTime? CreatedAt { get; set; }

    public string? Euin { get; set; }

    public DateTime? CreatedOn { get; set; }

    public bool? Isactive1 { get; set; }
}
