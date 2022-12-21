using System.ComponentModel.DataAnnotations;
namespace Webprogramlama.Models
{
    public class Cars
    {
        [Key]
        public int id { get; set; }
        
        public string brand { get; set; }

        public string model { get; set; }

        public int fiyat    { get; set; }

        public string   Category { get; set; }   
    }
}
