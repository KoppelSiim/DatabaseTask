using System.ComponentModel.DataAnnotations;


namespace DatabaseTask.Core.Domain
{
    public class Rental
    {
        [Key]
        public Guid Id { get; set; }
        public string ItemName { get; set; }
        public DateTime RentalStart {get;set;}
        public DateTime? RentalEnd { get; set; }
        public string? Comment { get; set; }

        //Foreign key properties to reference Employee
        public Employee Employee { get; set; }
        public Guid EmployeeId { get; set; }
    }
}
