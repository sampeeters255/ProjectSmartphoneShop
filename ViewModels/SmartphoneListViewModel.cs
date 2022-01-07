using ProjectSmartphoneShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectSmartphoneShop.ViewModels
{
    public class SmartphoneListViewModel
    {
        public string SmartphoneSearch { get; set; }
        public List<Smartphone> Smartphones { get; set; }
    }
}
