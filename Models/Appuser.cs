using System.ComponentModel.DataAnnotations;

namespace Webprogramlama.Models
{
    public class AppUser
    {
        [Key]
        public int? Pace { get; set; } 
        public int? Mileage { get; set; }

        public Address? Address { get; set; } 

        public ICollection<Club> Clubs { get; set; }

        public ICollection<Race> Races { get; set; }
    }
}
