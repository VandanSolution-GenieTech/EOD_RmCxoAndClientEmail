using System;
using System.Collections.Generic;

namespace DataService.Models;

public partial class IbeatsDocumentTypeMaster
{
    public int Id { get; set; }

    public int InvestorType { get; set; }

    public int DocumentTypeId { get; set; }

    public string IbeatsDocIdList { get; set; } = null!;

    public string IbeatsDocType { get; set; } = null!;

    public int IbeatsDocId { get; set; }

    public string IbeatsDocName { get; set; } = null!;

    public bool AttachmentStatus { get; set; }

    public int Cbecode { get; set; }

    public int? MaxFileSize { get; set; }

    public bool IsActive { get; set; }

    public DateTime? CreatedOn { get; set; }

    public DateTime? ModifiedOn { get; set; }
}
