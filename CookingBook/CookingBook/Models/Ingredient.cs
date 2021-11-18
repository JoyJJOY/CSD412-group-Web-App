using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CookingBook.Models
{
    public class Ingredient
    {

        [Required]
        public string Name { get; set; }
        [Required]
        public double Amount { get; set; }
        [Required]
        public string Unit { get; set; }
    }
}
