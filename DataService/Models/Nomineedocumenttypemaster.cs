using System;
using System.Collections.Generic;

namespace DataService.Models;

public partial class Nomineedocumenttypemaster
{
    public int Id { get; set; }

    public int ClientTypeId { get; set; }

    public int? ClientSubTypeId { get; set; }

    public string? DocumentName { get; set; }

    public bool? IsExpiredType { get; set; }

    public bool? IsOcrrequired { get; set; }

    public bool? IsActive { get; set; }

    public bool? IsDeleted { get; set; }

    public int CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }
}
