using ClothingML.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ClothingML.Models
{
    public class ProductModel
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [MaxLength(200)]
        public string Description { get; set; }

        [Required]
        public SizeEnum Size { get; set; }

        [Required]
        public CategoryEnum Category { get; set; }

        [Required]
        [Range(0, 99999999)]
        public double Price { get; set; }

        [Required]
        public string ImageRef { get; set; }



    }
}
