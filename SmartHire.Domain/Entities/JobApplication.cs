namespace SmartHire.Domain.Entities;

using SmartHire.Domain.Enums;

public class JobApplication
{
    public Guid Id { get; set; }
    public string ResumeText { get; set; } = string.Empty;
    public ApplicationStatus Status { get; set; } = ApplicationStatus.Applied;
    public DateTime AppliedAt { get; set; } = DateTime.UtcNow;

    // Which candidate applied
    public Guid CandidateId { get; set; }
    public User Candidate { get; set; } = null!;

    // Which job they applied to
    public Guid JobId { get; set; }
    public Job Job { get; set; } = null!;
}