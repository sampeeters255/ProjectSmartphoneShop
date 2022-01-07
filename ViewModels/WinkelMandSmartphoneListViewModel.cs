using ProjectSmartphoneShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectSmartphoneShop.ViewModels
{
    public class WinkelMandSmartphoneListViewModel
    {
        public List<WinkelMandSmartphone> winkelMandSmartphones { get; set; }
        public Klant Klant { get; set; }
        public WinkelMand WinkelMand { get; set; }
        public Order Order { get; set; }
        public Smartphone Smartphone { get; set; }
        public List<Smartphone> Smartphones { get; set; }
    }
}
