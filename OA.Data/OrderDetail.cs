using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OA.Data
{
    public class OrderDetail : BaseEnity
    {
        public OrderDetail(int quantity, double price, int orderId, int productId)
        {
            Quantity = quantity;
            Price = price;
            OrderId = orderId;
            ProductId = productId;
        }

        [Required]
        public int Quantity { get; private set; }
        [Required]
        public double Price { get; set; }
        public int OrderId { get; private set; }
        public Order Order { get; private set; }
        public int ProductId { get; private set; }
        public Product Product { get; private set; }

        public void Modify(int quantity, double price, int orderId, int productId)
        {
            Quantity = quantity;
            Price = price;
            OrderId = orderId;
            ProductId = productId;
        }
    }
}
