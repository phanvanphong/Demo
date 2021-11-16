using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OA.Data
{
    public class Order : BaseEnity
    {
        public Order(string date, string notes, string address, int status, int customerId)
        {
            Date = date;
            Notes = notes;
            Address = address;
            Status = status;
            CustomerId = customerId;
        }

        public string Date { get; private set; }
        [Required]
        public string Notes { get; private set; }
        [Required]
        public string Address { get; private set; }
        public int Status { get; private set; }
        public int CustomerId { get; private set; }
        public Customer Customer { get; private set; }

        public void Modify(string date, string notes, string address, int status, int customerId)
        {
            Date = date;
            Notes = notes;
            Address = address;
            Status = status;
            CustomerId = customerId;
        }
    }
}
