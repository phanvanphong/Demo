using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoDotNet5.ViewModel
{
    public class OrderViewModel
    {
        public int Id { get; set; }
        public string Date { get; set; }
        public string Notes { get; set; }
        public string Address { get; set; }
        public int Status { get; set; }
        public int CustomerId { get; set; }
        public string CustomerFullname { get; set; }
    }
}
