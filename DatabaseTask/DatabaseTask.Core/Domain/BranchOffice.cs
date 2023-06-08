using System.ComponentModel.DataAnnotations;

namespace DatabaseTask.Core.Domain
{
    public class BranchOffice
    {
        [Key]
        public Guid Id { get; set; }
        public int BranchOfficeRegisterNumber { get; set; }
        public string Name { get; set; }
        public string ShortName { get; set; }
        public string WebSite { get; set; }
        public string Address { get; set; }
        public string ContactPerson { get; set; }
        public int ContactPhone { get; set; }
        public string ContactEmail { get; set; }
        public string? Comment { get; set; }

        // Foreign key property to reference the associated company
        public Guid CompanyId { get; set; }
        public Company Company { get; set; }
        // Navigation property to represent the relationship with employees
        public ICollection<Employee> Employees { get; set; } = new List<Employee>();
    }
}
