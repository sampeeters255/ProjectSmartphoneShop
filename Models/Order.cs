using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectSmartphoneShop.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public string Gemeente { get; set; }
        public string Straat { get; set; }
        public string Nummer { get; set; }
        public WinkelMand WinkelMand { get; set; }
    }
}
