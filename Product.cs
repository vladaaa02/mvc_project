using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SportsStore.Models
{
    public class Product
    {
        public long? ProductID { get; set; }


        [Required(ErrorMessage = "Molim Vas unesite naziv proizvoda")]
        public string Name { get; set; } = String.Empty; 


        [Required(ErrorMessage = "Molim Vas ubacite opis")]       
        public string Description { get; set; } = String.Empty;
        
        
        [Required]
        [Range(0.01, double.MaxValue, ErrorMessage = "Molim Vas unesite pozitivnu cenu")]
        public decimal Price { get; set; }
        
        [Required(ErrorMessage = "Molim Vas navedite kategoriju")]
        public string Category { get; set; } = String.Empty;
    }
}