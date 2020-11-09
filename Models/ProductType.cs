using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace JubiLarian.Models
{
    public class ProductType
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [DataType(DataType.Text)]
        [StringLength(90)]
        [Display(Name = "Nazwa Typu")]
        public string Name { get; set; }
        [DataType(DataType.Text)]
        [StringLength(150)]
        [Display(Name = "Przeznaczenie")]
        public string Destiny { get; set; }

        public ICollection<Product> Products { get; set; }
    }
}
