using ProjectSmartphoneShop.Areas.Identity.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectSmartphoneShop.ViewModels
{
    public class GebruikerListViewModel
    {
        public List<CustomUser> Gebruikers { get; set; }
    }
}
