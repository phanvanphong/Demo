using OA.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OA.Interface
{
    public interface IOrderDetailService
    {
        public Task<int> Count();
        public Task<OrderDetail> GetId(int id);
        public Task Insert(int quantity, double price, int orderId, int productId);
        public Task Update(int id, int quantity, double price, int orderId, int productId);
        public Task Delete(long id);
        public Task<Pager<OrderDetail>> GetOrderDetails(int id, int currentPage, int pageSize);
    }
}
