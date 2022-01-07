using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectSmartphoneShop.Models
{
    public class Klant
    {
        public int KlantId { get; set; }
        public string Email { get; set; }
        
        [Display(Name = "Datum Aangemaakt")]
        [DataType(DataType.Date)]
        public DateTime GeboorteDatum { get; set; }
        public ICollection<WinkelMand> WinkelManden { get; set; }
    }
}
