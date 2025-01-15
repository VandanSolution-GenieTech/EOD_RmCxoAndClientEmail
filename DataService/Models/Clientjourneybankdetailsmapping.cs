﻿using System;
using System.Collections.Generic;

namespace DataService.Models;

public partial class Clientjourneybankdetailsmapping
{
    public int Id { get; set; }

    public int InvId { get; set; }

    public int BankDetailsId { get; set; }

    public bool IsActive { get; set; }

    public DateTime? CreatedOn { get; set; }

    public DateTime? ModifiedOn { get; set; }
}