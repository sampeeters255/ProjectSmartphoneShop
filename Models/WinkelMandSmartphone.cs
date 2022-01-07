using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectSmartphoneShop.Models
{
    public class WinkelMandSmartphone
    {
        public int WinkelMandSmartphoneId { get; set; }
        public int WinkelmandId { get; set; }
        public int SmartphoneId { get; set; }
        public WinkelMand WinkelMand { get; set; }
        public Smartphone Smartphone { get; set; }
    }
}
