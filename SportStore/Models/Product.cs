using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SportStore.Models
{

    public class Product
    {

        public long ProductID { get; set; }

        [Required(ErrorMessage = "Podaj nazwę produktu")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Podaj opis produktu")]
        public string Description { get; set; }

        [Range(0.01, double.MaxValue, ErrorMessage = "Podaj cenę produktu")]
        [Column(TypeName = "decimal(8, 2)")]
        public decimal Price { get; set; }

        [Required(ErrorMessage = "Podaj kategorię produktu")]
        public string Category { get; set; }
    }
}
