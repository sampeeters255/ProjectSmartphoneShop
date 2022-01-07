using ProjectSmartphoneShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectSmartphoneShop.ViewModels
{
    public class CreateWinkelMandViewModel
    {
        public List<WinkelMandSmartphone> WinkelMandSmartphones { get; set; }
        public Klant Klant { get; set; }
    }
}
