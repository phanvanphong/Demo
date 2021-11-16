using OA.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OA.Interface
{
    public interface IOrderService
    {
        public Task<int> Count();
        public Task<Order> GetId(int id);
        public Task<Order> Insert(string date, string notes, string address, int status, int customerId);
        public Task Update(int id, string date, string notes, string address, int status, int customerId);
        public Task Delete(long id);
        public Task<Pager<Order>> GetOrders(string search, int currentPage, int pageSize);
    }
}
