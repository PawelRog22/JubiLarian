using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace JubiLarian.Models.Helper
{
    public class NewProduct
    {
        [Display(Name = "Numer produktu: ")]
        public int NumerProduct { get; set; }
        [Display(Name = "Nazwa produktu: ")]
        public string Name { get; set; }
        [Display(Name = "Nazwa producenta: ")]
        public string Producent { get; set; }
        [Display(Name = "Dostepność: ")]
        public bool IsAvailable { get; set; }
        [Display(Name = "Cena: ")]
        public decimal Price { get; set; }
    }
}
