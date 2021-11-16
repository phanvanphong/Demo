using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoDotNet5.ViewModel
{
    public class OrderDetailViewModel
    {
        public int Quantity { get; private set; }
        public double Price { get; set; }
        public int OrderId { get; private set; }
        public string ProductName { get; set; }
        public string ProductImage { get; set; }
        public int ProductId { get; private set; }

    }
}
