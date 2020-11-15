using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JubiLarian.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "{0} jest obowiązkowa!")]
        [StringLength(60, ErrorMessage ="{0} musi być do 60 znaków!")]
        [DataType(DataType.Text)]
        [Display(Name = "Nazwa")]
        public string Name { get; set; }

        [StringLength(250, ErrorMessage = "{0} musi być do 250 znaków!")]
        [DataType(DataType.MultilineText)]
        [Display(Name = "Opis")]
        public string Description { get; set; }

        [Required(ErrorMessage = "{0} jest obowiązkowa!")]
        [Range(0,9000, ErrorMessage = "{0} nie możesz przekroczyć 9000 szt.")]
        [Display(Name="Ilość")]
        public int Quantity { get; set; }

        [Required(ErrorMessage = "{0} jest obowiązkowa!")]
        [Column(TypeName = "decimal(18,2)")]
        [DataType(DataType.Currency)]
        [Display(Name="Cena")]
        public decimal Price { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "Pole musi być wybrane!")]
        [Display(Name= "Producent")]
        public virtual int ProducentId { get; set; }
        public virtual Producent Producent { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "Pole musi być wybrane!")]
        [Display(Name = "Typ")]
        public virtual int TypeId { get; set; }
        public virtual ProductType Type { get; set; }
    }
}
