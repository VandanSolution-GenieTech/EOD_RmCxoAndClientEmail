using System;
using System.Collections.Generic;

namespace DataService.Models;

public partial class Employeemasterbackup
{
    public int Id { get; set; }

    public string? FirstName { get; set; }

    public string? MiddleName { get; set; }

    public string? LastName { get; set; }

    public int DesignationId { get; set; }

    public int? TeamId { get; set; }

    public int? Sbuid { get; set; }

    public int? EntityId { get; set; }

    public int? RoleId { get; set; }

    public DateOnly? Doj { get; set; }

    public decimal? Mobile { get; set; }

    public string? Email { get; set; }

    public bool? IsExternal { get; set; }

    public int? BankerId { get; set; }

    public int? StatusId { get; set; }

    public string? PhotoImg { get; set; }

    public string? SignImg { get; set; }

    public string? QrcodeImg { get; set; }

    public bool? IsActive { get; set; }

    public bool? IsDeleted { get; set; }

    public int? Createdby { get; set; }

    public DateTime? CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }
}
