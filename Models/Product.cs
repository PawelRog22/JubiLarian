using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JubiLarian.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Display(Name="Nazwa")]
        [StringLength(60)]
        [DataType(DataType.Text)]
        public string Name { get; set; }
        [Display(Name="Opis")]
        [StringLength(250)]
        [DataType(DataType.Text)]
        public string Description { get; set; }
        [Display(Name="Zdjęcie")]
        public byte Images { get; set; }
        [Range(0,9000)]
        [Required]
        [Display(Name="Ilość")]
        public int Quantity { get; set; }
        [Required]
        [Display(Name="Cena")]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }

        public virtual Producent Producent { get; set; }

        public virtual ProductType Type { get; set; }
    }
}
