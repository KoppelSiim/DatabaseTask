using System.ComponentModel.DataAnnotations;


namespace DatabaseTask.Core.Domain
{
    public class Employee
    {
        [Key]
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int SocialSecurityNumber { get; set; }
        public string ContactAddress { get; set; }
        public int ContactPhone { get; set; }

        public string ContactEmail { get; set; }
        public DateTime StartOfEmployment { get; set; }
        public DateTime? EndOfEmployment { get; set; }

        public string? Comment { get; set; }

       
        // Foreign key properties to reference with Branch Office
        public BranchOffice BranchOffice { get; set; }
        public Guid BranchOfficeId { get; set; }

        // Navigation property to represent the relationship with Job Titles
        public ICollection<JobTitles> JobTitles { get; set; } = new List<JobTitles>();

        // Navigation property to represent the relationship with Children
        public ICollection<Children> Children { get; set; } = new List<Children>();

        // Navigation property to represent the relationship with Vacations
        public ICollection<Vacations> Vacations { get; set; } = new List<Vacations>();

        // Navigation property to represent the relationship with SickLeaves
        public ICollection<SickLeaves> SickLeaves { get; set; } = new List<SickLeaves>();

        // Navigation property to represent the relationship with AccessPermissions
        public ICollection<AccessPermissions> AccessPermissions { get; set; } = new List<AccessPermissions>();

        // Navigation property to represent the relationship with HealthInspection
        public ICollection<HealthInspection> HealthInspections { get; set; } = new List<HealthInspection>();

        // Navigation property to represent the relationship with Rental
        public ICollection<Rental> Rentals { get; set; } = new List<Rental>();


    }

}
