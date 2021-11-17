using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DemoDotNet5.ViewModel
{
    public class CustomerViewModel
    {
     
        public int Id { get; set; }
        [Required]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string Fullname { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public string Email { get; set; }
        public string CreatedAt { get; set; }
        public int UserProfileId { get; set; }
        public ICollection<OrderViewModel> Orders { get; set; }

        public string UserProfileFullName { get; set; }

        // Thêm thuộc tính Token
        public string Token { get; set; }
    }
}
