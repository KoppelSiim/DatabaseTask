using System.ComponentModel.DataAnnotations;

namespace DatabaseTask.Core.Domain
{
    public class Children
    {

        [Key]
        public Guid Id { get; set; }
        public string ChildFirstName { get; set; }
        public string ChildLastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int Age { get; set; }
        public string? Comment { get; set; }

        //Foreign key properties to reference Employee
        public Employee Employee { get; set; }
        public Guid EmployeeId { get; set; }
    }
}
