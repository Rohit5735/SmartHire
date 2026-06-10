namespace SmartHire.Domain.Entities;

using SmartHire.Domain.Enums;

public class Job
{
    public Guid Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string Location { get; set; } = string.Empty;
    public decimal Salary { get; set; }
    public JobType JobType { get; set; }
    public DateTime PostedAt { get; set; } = DateTime.UtcNow;
    public bool IsActive { get; set; } = true;

    // Which employer posted this job
    public Guid EmployerId { get; set; }
    public User Employer { get; set; } = null!;

    // All applications for this job
    public ICollection<JobApplication> Applications { get; set; } = new List<JobApplication>();
}