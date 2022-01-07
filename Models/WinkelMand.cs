using ProjectSmartphoneShop.Areas.Identity.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectSmartphoneShop.Models
{
    public class WinkelMand
    {
        public int WinkelMandId { get; set; }
        public int KlantId { get; set; }
        public int SmartphoneId { get; set; }
        public int OrderId { get; set; }

        public decimal TotaalPrijs { get; set; }
        [Display(Name = "Datum Aangemaakt")]
        [DataType(DataType.Date)]
        public DateTime BestelDatum { get; set; }
        [NotMapped]
        public Klant Klant { get; set; }
        public ICollection<WinkelMandSmartphone> WinkelMandSmartphones { get; set; }
        public ICollection<Order> Orders { get; set; }
    }
}
