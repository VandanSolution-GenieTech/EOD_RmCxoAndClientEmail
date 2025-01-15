using System;
using System.Collections.Generic;

namespace DataService.Models;

public partial class Onbinvriskprofileanswerdetail
{
    public int Id { get; set; }

    public int InvId { get; set; }

    public int? QuestionId { get; set; }

    public int? AnswerTypeId { get; set; }

    public string? QuestionSection { get; set; }

    public string? Answer { get; set; }

    public bool? IsActive { get; set; }

    public bool? IsDeleted { get; set; }

    public int CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public int ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }
}
