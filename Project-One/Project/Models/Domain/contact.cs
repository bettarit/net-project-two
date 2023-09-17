using System.ComponentModel.DataAnnotations;

namespace Project.Models.Domain
{
    public class contact
    {
        [Required]
        public Guid ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Telephone { get; set; }
        public string Email { get; set; }
        public DateTime Date { get; set; }=DateTime.Now;


        
    }
}

