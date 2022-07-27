using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Day30.Practice.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Product Name cannot be empty")]
        [Display(Name = "Product Name")]
        public string ProductName { get; set; }

        [Required]
        public decimal Price { get; set; }

        [Required]
        [Range(1, 200, ErrorMessage = "Quantity must be between 1 and 200")]
        public short Quantity { get; set; }

        //Auditable Column
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public DateTime? ModifiedDate { get; set; }

        //Reference Table
        public Category Category { get; set; }
        //Foreign Key Column
        [Required]
        [Display(Name = "Category Name")]
        public int CategoryId { get; set; }
    }
}