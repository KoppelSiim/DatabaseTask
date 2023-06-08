using System.ComponentModel.DataAnnotations;


namespace DatabaseTask.Core.Domain
{
    public class Vacations
    {

        [Key]
        public Guid Id { get; set; }
        public int TotalVacationDays { get; set; }
        public DateTime StartOfVaction { get; set; }
        public DateTime EndOfVacation { get; set; }
        public int VacationDaysUsed { get; set; }
        public int VacationDaysLeft { get; set; }
        public int VacationDaysExpired { get; set; }
        public string? Comment { get; set; }

        //Foreign key relationships with Employee
        public Employee Employee { get; set; }
        public Guid EmployeeId { get; set; }
    }
}