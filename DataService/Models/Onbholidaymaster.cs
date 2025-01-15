using System;
using System.Collections.Generic;

namespace DataService.Models;

public partial class Onbholidaymaster
{
    public int? Id { get; set; }

    public DateOnly? HolidayDate { get; set; }

    public string? HolidayDays { get; set; }

    public string? HolidayName { get; set; }

    public string? IsActive { get; set; }

    public string? IsDeleted { get; set; }

    public string? CreatedBy { get; set; }

    public string? CreatedOn { get; set; }

    public string? ModifiedBy { get; set; }

    public string? ModifiedOn { get; set; }
}
