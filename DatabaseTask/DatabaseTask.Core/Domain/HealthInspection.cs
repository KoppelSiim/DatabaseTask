using System.ComponentModel.DataAnnotations;

namespace DatabaseTask.Core.Domain
{
    public class HealthInspection
    {
        [Key]
        public Guid Id { get; set; }
        public bool NeedForHealthInspection { get; set; }
        public DateTime? PreviousHealthInspection { get; set; }
        public DateTime? NextHealthInspection { get; set; }
        public string? Comment { get; set; }

        // Foreign key properties to reference Employee
        public Employee Employee { get; set; }
        public Guid EmployeeId { get; set; }
    }
}
