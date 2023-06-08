using System.ComponentModel.DataAnnotations;

namespace DatabaseTask.Core.Domain
{
    public class JobTitles
    {
        [Key]
        public Guid Id { get; set; }
        public string JobTitleName { get; set; }
        public DateTime JobTitleStart { get; set; }
        public DateTime? JobTitleEnd { get; set; }
        public string Department { get; set; }
        public string ManagerFirstName { get; set; }
        public string ManagerLastName { get; set; }
        public int ManagerContactPhone { get; set; }
        public string ManagerContactEmail { get; set; }
        public string? Comment { get; set; }

        // Foreign key properties to reference Employee
        public Employee Employee { get; set; }
        public Guid EmployeeId { get; set; }
    }
}
