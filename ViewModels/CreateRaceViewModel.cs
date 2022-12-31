using Webprogramlama.Data.Enum;
using Webprogramlama.Models;

namespace Webprogramlama.ViewModels
{
    public class CreateRaceViewModel
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public Address Address { get; set; }
        public IFormFile Image { get; set; }
        public RaceCategory RaceCategory { get; set; }
    }
}
