using DemoDotNet5.Data;
using OA.Data;
using OA.Interface;
using OA.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OA.Service
{
    public class OrderService : IOrderService
    {
        private readonly IRepository<Order> _orderRepository;
        private readonly EShopDbContext _context;
        public OrderService(IRepository<Order> orderRepository, EShopDbContext context)
        {
            _orderRepository = orderRepository;
            _context = context;
        }
        public async Task Delete(long id)
        {
            Order order = await _orderRepository.Get(id);

            await _orderRepository.Delete(order);
            //customerRepository.Remove(customer);
            //customerRepository.SaveChanges();
        }

        public async Task<Order> GetId(int id)
        {
            return await _orderRepository.Get(id);
        }

        public async Task<int> Count()
        {
            return await _orderRepository.Count();
        }

        public async Task<Order> Insert(string date, string notes, string address, int status, int customerId)
        {
            var order = new Order(date, notes, address, status, customerId);
            var data = await _orderRepository.InsertReturn(order);
            return data;
        }

        public async Task Update(int id, string date, string notes, string address, int status, int customerId)
        {
            var order = await _orderRepository.Get(id);
            order.Modify(date, notes, address, status, customerId);
            await _orderRepository.Update(order);
        }

        public async Task<Pager<Order>> GetOrders(string search, int currentPage, int pageSize)
        {

            if (search == null) search = "";
            var result = await _orderRepository.Paging(o => o.Address.Contains(search), currentPage, pageSize,c => c.Customer);
            return result;
        }
    }
}
