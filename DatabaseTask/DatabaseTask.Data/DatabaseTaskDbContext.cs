using DatabaseTask.Core.Domain;
using Microsoft.EntityFrameworkCore;


namespace DatabaseTask.Data
{
    public class DatabaseTaskDbContext : DbContext
    {
        public DatabaseTaskDbContext(DbContextOptions<DatabaseTaskDbContext> options)
            : base(options) { }

       
        public DbSet<AccessPermissions> AccessPermissions { get; set; }
        public DbSet<BranchOffice> BranchOffices { get; set; }
        public DbSet<Children> Children { get; set; }
        public DbSet<Company> Company { get; set; }
        public DbSet<Employee> Employee { get; set; }
        public DbSet<HealthInspection> HealthInspections { get; set; }
        public DbSet<JobTitles> JobTitles { get; set; }
        public DbSet<Rental> Rentals { get; set; }
        public DbSet<SickLeaves> SickLeaves { get; set; }
        public DbSet<Vacations> Vacations { get; set; }

    }
}