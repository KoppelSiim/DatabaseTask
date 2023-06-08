using System.ComponentModel.DataAnnotations;

namespace DatabaseTask.Core.Domain
{
   public class AccessPermissions
    {

        [Key]
        public Guid Id { get; set; }
        public bool AccessRight { get; set; }
        public string AccessLevel { get; set; }
        public DateTime AccessStartTime { get; set; }
        public DateTime AccessEndTime { get; set; }
        public string? Comment { get; set; }

        //Foreign key properties to reference Employee
        public Employee Employee { get; set; }
        public Guid EmployeeId { get; set; }
    }
}
