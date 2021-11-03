using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OA.Data
{
    public class Category : BaseEnity
    {
        public Category(string name, string description)
        {
            Name = name;
            Description = description;
        }
        [Required]
        public string Name { get; private set; }
        [Required]
        public string Description { get; private set; }
        public ICollection<Product> Products { get; private set; }

        public void Modify(string name, string description)
        {
            Name = name;
            Description = description;
        }
    }

    
}
