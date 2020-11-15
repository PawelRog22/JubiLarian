using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace JubiLarian.Models.Helper
{
    public class AllDetailsInfo
    {
        [Display(Name = "Numer produktu:")]
        public int ProductNumber { get; set; }
        [Display(Name = "Nazwa produktu:")]
        public string ProductName { get; set; }
        [Display(Name = "Typ produktu:")]
        public string TypeProduct { get; set; }
        [Display(Name = "Opis produktu:")]
        public string Description { get; set; }
        [Display(Name = "Przeznaczenie:")]
        public string Destinayion { get; set; }
        [Display(Name = "Nazwa producenta:")]
        public string Producent { get; set; }
        [Display(Name = "Ares producenta:")]
        public string Address { get; set; }
        [Display(Name = "Ilość w magazynie:")]
        public int Quantity { get; set; }
        [Display(Name = "Cena za sztukę")]
        public decimal Price { get; set; }
    }
}
