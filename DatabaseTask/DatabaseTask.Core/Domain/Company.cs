using System.ComponentModel.DataAnnotations;

namespace DatabaseTask.Core.Domain
{
    public class Company
    {
        [Key]
        public Guid Id { get; set; }
        public string RegisterNumber { get; set; }
        public string Name { get; set; }
        public string ShortName { get; set; }
        public string WebSite { get; set; }
        public string Address { get; set; }
        public string ContactPerson { get; set; }
        public int ContactPhone { get; set; }
        public string ContactEmail { get; set; }
        public string ?Comment {get;set;}

    }
}
