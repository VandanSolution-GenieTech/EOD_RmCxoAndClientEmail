using System;
using System.Collections.Generic;

namespace DataService.Models;

public partial class Riskprofilequestionmaster
{
    public int Id { get; set; }

    public int EntityId { get; set; }

    public int ProductId { get; set; }

    public int ProductSubTypeId { get; set; }

    public int ClientTypeId { get; set; }

    public bool? IsChildQuestionPresent { get; set; }

    public int ParentQuestionId { get; set; }

    public string? QuestionSection { get; set; }

    public string? Question { get; set; }

    public int? AnswerTypeId { get; set; }

    public bool? IsActive { get; set; }

    public bool? IsDeleted { get; set; }

    public int CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public int ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }
}
