using System.ComponentModel.DataAnnotations;

namespace Webprogramlama.Models
{
    public class AppUser
    {
        [Key]
        public int? Id { get; set; } 
        public int? km { get; set; }

        public Address? Address { get; set; } 

        public ICollection<Club> Clubs { get; set; }

        public ICollection<Race> Races { get; set; }
    }
}
