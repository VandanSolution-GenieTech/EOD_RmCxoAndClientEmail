using System;
using System.Collections.Generic;

namespace DataService.Models;

public partial class Signzyvideokycresponsewebhook
{
    public int Id { get; set; }

    public string? CoVariance { get; set; }

    public string? MatchPercentage { get; set; }

    public string? VideoImages { get; set; }

    public string? FinalMatchImage { get; set; }

    public string? MatchStatistics { get; set; }

    public string? MatchAudioScore { get; set; }

    public string? Verified { get; set; }

    public string? Message { get; set; }

    public string? StaticRisk { get; set; }

    public string? PrerecordedRisk { get; set; }

    public string? VideoLandmarks { get; set; }

    public string? FaceLandmarks { get; set; }

    public string? Liveliness { get; set; }

    public string? Latitude { get; set; }

    public string? Longitude { get; set; }

    public string? Token { get; set; }

    public string? VideoUrl { get; set; }

    public string? CallbackUrl { get; set; }

    public string? IsUsed { get; set; }

    public string? Video { get; set; }

    public string? Otp { get; set; }

    public string? FaceFound { get; set; }

    public ulong? IsAudioProcessed { get; set; }

    public ulong? IsVideoProcessed { get; set; }

    public DateTime? Timestamp { get; set; }
}
