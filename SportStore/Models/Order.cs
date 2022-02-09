using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SportStore.Models
{
    public class Order
    {
        [BindNever]
        public int OrderID { get; set; }
        [BindNever]
        public ICollection<CartLine> Lines { get; set; }

        [Required(ErrorMessage = "Podaj imię")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Podaj adres")]
        public string Line { get; set; }

        [Required(ErrorMessage = "Podaj miasto")]
        public string City { get; set; }

        [Required(ErrorMessage = "Podaj województwo")]
        public string State { get; set; }

        public string Zip { get; set; }

        [Required(ErrorMessage = "Podaj kraj")]
        public string Country { get; set; }

        public bool GiftWrap { get; set; }

        [BindNever]
        public bool Shipped { get; set; }
    }
}
