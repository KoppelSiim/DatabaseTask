using System.ComponentModel.DataAnnotations;


namespace DatabaseTask.Core.Domain
{
    public class SickLeaves
    {

        [Key]
        public Guid Id { get; set; }
        public bool SickLeavePermission { get; set; }
        public int SickDaysTotal { get; set; }
        public DateTime SickLeaveStart { get; set; }
        public DateTime SickLeaveEnd { get; set; }
        public int SickDaysUsed { get; set; }
        public int SickDaysRemaining { get; set; }
        public int SickDaysExpired { get; set; }
        public string? Comment { get; set; }

        //Foreign key properties to reference Employee
        public Employee Employee { get; set; }
        public Guid EmployeeId { get; set; }
    }
}
