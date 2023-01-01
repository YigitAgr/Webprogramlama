﻿using Webprogramlama.Data.Enum;
using Webprogramlama.Models;

namespace Webprogramlama.ViewModels
{
    public class EditClubViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        
        public string Description { get; set; }
        public int AddressId { get; set; }
        public string? URL { get; set; }
        public Address Address { get; set; }
        public IFormFile Image { get; set; }
        public ClubCategory ClubCategory { get; set; }
    }
}
