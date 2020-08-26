using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdeToFood.Data.Models
{
    public class Restaurant
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(255)]
        public string Name { get; set; }
        [DisplayFormat(NullDisplayText = "Choose Cuisine")]
        [Display(Name="Type of Food")]
        public CuisineType Cuisine { get; set; }

    }
}
