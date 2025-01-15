using System;
using System.Collections.Generic;

namespace DataService.Models;

public partial class WsStagingClientkradetail
{
    public int Id { get; set; }

    public string? GroupId { get; set; }

    public string? OwnerId { get; set; }

    public string? ClientId { get; set; }

    public string? ClientCode { get; set; }

    public string? Gender { get; set; }

    public string? FirstName { get; set; }

    public string? MiddleName { get; set; }

    public string? LastName { get; set; }

    public string? Fullname { get; set; }

    public string? Pan { get; set; }

    public string? Mobile { get; set; }

    public DateOnly? Dob { get; set; }

    public string? Aadhar { get; set; }

    public string? Email { get; set; }

    public string? Add1 { get; set; }

    public string? Add2 { get; set; }

    public string? Add3 { get; set; }

    public string? City { get; set; }

    public string? State { get; set; }

    public string? Pin { get; set; }

    public string? Ucccode { get; set; }

    public string? AccountType { get; set; }

    public string? AccountStatus { get; set; }

    public string? RmName { get; set; }

    public bool? IsInternal { get; set; }

    public bool? Isactive { get; set; }

    public DateTime? CreatedOn { get; set; }
}
