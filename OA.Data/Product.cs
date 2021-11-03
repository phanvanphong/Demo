using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using System.Web;


namespace OA.Data
{
    public class Product : BaseEnity
    {
        public Product(string name, string price, int categoryId, string image)
        {
            Name = name;
            Price = price;
            CategoryId = categoryId;
            Image = image;
        }

        [Required]
        public string Name { get; set; }
        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "Price must be greater than 0")]
        public string Price { get; set; }
        [Required]
        public string Image { get; set; }
        //[ForeignKey("Category")]
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        
        public void Modify(string name, string price, int categoryId, string image)
        {
            Name = name;
            Price = price;
            CategoryId = categoryId;
            Image = image;
        }
         
    }
}
