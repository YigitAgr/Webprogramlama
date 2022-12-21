using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Webprogramlama.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        public string Categoryname    { get; set; }
        [ForeignKey("Cars")]
        public int CarsId { get; set; }
         

    }
}
