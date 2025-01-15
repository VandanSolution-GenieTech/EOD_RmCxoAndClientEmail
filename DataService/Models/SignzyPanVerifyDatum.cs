using System;
using System.Collections.Generic;

namespace DataService.Models;

public partial class SignzyPanVerifyDatum
{
    public string Id { get; set; } = null!;

    public string PatronId { get; set; } = null!;

    public string Number { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string TypeOfHolder { get; set; } = null!;

    public bool IsIndividual { get; set; }

    public bool IsValid { get; set; }

    public string FirstName { get; set; } = null!;

    public string? MiddleName { get; set; }

    public string LastName { get; set; } = null!;

    public string Title { get; set; } = null!;

    public string PanStatus { get; set; } = null!;

    public string PanStatusCode { get; set; } = null!;

    public string AadhaarSeedingStatus { get; set; } = null!;

    public string AadhaarSeedingStatusCode { get; set; } = null!;

    public string LastUpdatedOn { get; set; } = null!;

    public DateTime TimeStamp { get; set; }
}
