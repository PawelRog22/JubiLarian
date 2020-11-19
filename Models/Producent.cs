using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace JubiLarian.Models
{
    public class Producent
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "{0} jest obowiązkowa!")]
        [Display(Name = "Nazwa")]
        [StringLength(150)]
        [DataType(DataType.Text)]
        public string Name { get; set; }
        [Display(Name = "Adres")]
        [DataType(DataType.Text)]
        public string Address { get; set; }

        public ICollection<Product> Products { get; set; }
    }
}
