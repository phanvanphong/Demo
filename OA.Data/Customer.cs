using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OA.Data
{
    public class Customer : BaseEnity 
    {
        public Customer(string username, string password, string fullname, string address, string email, string createdat, int userprofileid)
        {
            Username = username;
            Password = password;
            Fullname = fullname;
            Address = address;
            Email = email;
            CreatedAt = createdat;
            UserProfileId = userprofileid;
        }
        public Customer()
        {

        }

        [Required]
        public string Username { get; private set; }
        [Required]
        public string Password { get; private set; }
        [Required]
        public string Fullname { get; private set; }
        [Required]
        public string Address { get; private set; }
        [Required]
        public string Email { get; private set; }
        public string CreatedAt { get; private set; }
        public int UserProfileId { get; private set; }
        public UserProfile UserProfile { get; private set; }


        public void Modify(string username, string password, string fullname, string address, string email, string createdat, int userprofileid)
        {
            Username = username;
            Password = password;
            Fullname = fullname;
            Address = address;
            Email = email;
            CreatedAt = createdat;
            UserProfileId = userprofileid;
        }

    }
}
