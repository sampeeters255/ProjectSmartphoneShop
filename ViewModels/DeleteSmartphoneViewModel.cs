using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectSmartphoneShop.ViewModels
{
    public class DeleteSmartphoneViewModel
    {
        public int SmartphoneId { get; set; }
        public decimal Prijs { get; set; }
        public string Model { get; set; }
        public string Merk { get; set; }
        [DisplayName("Image Name")]
        public string ImageName { get; set; }
        [NotMapped]
        [DisplayName("Upload File")]
        public IFormFile ImageFile { get; set; }
    }
}
