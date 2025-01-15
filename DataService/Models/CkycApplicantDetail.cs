using System;
using System.Collections.Generic;

namespace DataService.Models;

public partial class CkycApplicantDetail
{
    public int Id { get; set; }

    public int? InvId { get; set; }

    public int? HolderrankId { get; set; }

    public bool? Isactive { get; set; }

    public int? SalutationId { get; set; }

    public string? FirstName { get; set; }

    public string? MiddleName { get; set; }

    public string? LastName { get; set; }

    public int? MaidenSalutationId { get; set; }

    public string? MaidenFirstName { get; set; }

    public string? MaidenMiddleName { get; set; }

    public string? MaidenLastName { get; set; }

    public int? FatherSalutationId { get; set; }

    public string? FatherFirstName { get; set; }

    public string? FatherMiddleName { get; set; }

    public string? FatherLastName { get; set; }

    public int? MotherSalutationid { get; set; }

    public string? MotherFirstName { get; set; }

    public string? MotherMiddleName { get; set; }

    public string? MotherLastName { get; set; }

    public string? Mobile { get; set; }

    public string? Email { get; set; }

    public int? GenderId { get; set; }

    public string? Address { get; set; }

    public string? Pin { get; set; }

    public string? CityId { get; set; }

    public string? Pan { get; set; }

    public string? Dob { get; set; }

    public string? Ckycnumber { get; set; }
}
