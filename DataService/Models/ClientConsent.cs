using System;
using System.Collections.Generic;

namespace DataService.Models;

public partial class ClientConsent
{
    public int Id { get; set; }

    public int? InvId { get; set; }

    public string? Fullname { get; set; }

    public string? MobileNumber { get; set; }

    public string? EmailId { get; set; }

    public string? EmailOtp { get; set; }

    public bool? IsEmailOtpverified { get; set; }

    public DateTime? OtpVerifiedDate { get; set; }

    public DateTime? OtpSendDate { get; set; }

    public string? Consent { get; set; }

    public string? IsEmailSent { get; set; }

    public string? EmailRequest { get; set; }

    public string? EmailResponse { get; set; }

    public string? EmailStatusCode { get; set; }

    public string? IsSmsSent { get; set; }

    public string? SmsRequest { get; set; }

    public string? SmsResponse { get; set; }

    public string? SmsStatusCode { get; set; }

    public string? Guid { get; set; }

    public DateTime? ConsentDate { get; set; }

    public string? ShortUrl { get; set; }

    public string? MobileOtp { get; set; }

    public bool? IsMobileOtpverified { get; set; }

    public int? HolderRankId { get; set; }

    public bool? IsModification { get; set; }

    public int? ModificationId { get; set; }
}
