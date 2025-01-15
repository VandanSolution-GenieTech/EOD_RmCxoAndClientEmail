using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EOD_ClientEmail.DTOs
{
    public class EODSummaryModel
    {
        public int InvId { get; set; }
        public DateTime? OrderDate { get; set; }
        public DateTime? TransactionDate { get; set; }
        public string? Category { get; set; }
        public string? ClientName { get; set; }
        public string? TransactionType { get; set; }
        public string? AC_Type { get; set; }
        public string? AccountCode { get; set; }
        public string? SchemeOrScrip { get; set; }
        public string? ISIN { get; set; }
        public decimal? Amount { get; set; }
        public decimal? Units { get; set; }
        //public int Quantity { get; set; }
        public string? RMName { get; set; }
        public string? RMEmailId { get; set; }
        public string? CSOName { get; set; }
        public string? CSOEmailId { get; set; }
        public string? Status { get; set; }
        public string? ToAddress { get; set; }
        public string? FromAddress { get; set; }
        public string? ClientEmail { get; set; }
        public string? ClientPan { get; set; }
        public string? ReferenceNumber { get; set; }


    }
}
