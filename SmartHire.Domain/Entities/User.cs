namespace SmartHire.Domain.Entities;
using SmartHire.Domain.Enums;
   public class User
    {
        public Guid Id { get; set; }
        public string FullName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string PasswordHash { get; set; } = string.Empty;
        public UserRole Role { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public ICollection<Job> PostedJobs { get; set; } = new List<Job>();

    // One candidate can apply to many jobs
    public ICollection<JobApplication> Applications { get; set; } = new List<JobApplication>();
    }

   