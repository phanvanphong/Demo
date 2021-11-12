using OA.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoDotNet5.ViewModel
{
    public class CartItemViewModel
    {
        public ProductViewModel Product { get; set; }
        public int Quantity { get; set; }
    }
}
