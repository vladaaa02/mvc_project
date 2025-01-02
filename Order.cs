using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace SportsStore.Models
{
    public class Order
    {
        [BindNever]
        public int OrderID { get; set; }
        [BindNever]
        public ICollection<CartLine> Lines { get; set; } = new List<CartLine>();
        
        [Required(ErrorMessage = "Molim Vas unesite Vase ime")]
        public string? Name { get; set; }
        
        [Required(ErrorMessage = "Molim Vas unesite Vasu adresu")]
        public string? Line1 { get; set; }
        public string? Line2 { get; set; }
        public string? Line3 { get; set; }
        
        [Required(ErrorMessage = "Molim Vas unesite ime grada")]
        public string? City { get; set; }
        
        [Required(ErrorMessage = "Molim Vas unesite ime okruga")]
        public string? State { get; set; }
        
        public string? Zip { get; set; }
        
        [Required(ErrorMessage = "Molim Vas unesite ime drzave")]
        public string? Country { get; set; }
        
        public bool GiftWrap { get; set; }

        [BindNever]
        public bool Shipped { get; set; }
    }
}