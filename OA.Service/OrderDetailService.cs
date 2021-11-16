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
    public class OrderDetailService : IOrderDetailService
    {
        private readonly IRepository<OrderDetail> _orderDetailRepository;
        private readonly EShopDbContext _context;
        public OrderDetailService(IRepository<OrderDetail> orderDetailRepository, EShopDbContext context)
        {
            _orderDetailRepository = orderDetailRepository;
            _context = context;
        }
        public async Task Delete(long id)
        {
            OrderDetail orderDetail = await _orderDetailRepository.Get(id);

            await _orderDetailRepository.Delete(orderDetail);
            //customerRepository.Remove(customer);
            //customerRepository.SaveChanges();
        }

        public async Task<OrderDetail> GetId(int id)
        {
            return await _orderDetailRepository.Get(id);
        }

        public async Task<int> Count()
        {
            return await _orderDetailRepository.Count();
        }

        public async Task Insert(int quantity, double price, int orderId, int productId)
        {
            var orderDetail = new OrderDetail(quantity, price, orderId, productId);
            await _orderDetailRepository.Insert(orderDetail);
        }

        public async Task Update(int id, int quantity, double price, int orderId, int productId)
        {
            var order = await _orderDetailRepository.Get(id);
            order.Modify(quantity, price, orderId, productId);
            await _orderDetailRepository.Update(order);
        }

        public async Task<Pager<OrderDetail>> GetOrderDetails(int id, int currentPage, int pageSize)
        {
            var result = await _orderDetailRepository.Paging(o => o.OrderId == id, currentPage, pageSize, p => p.Product);
            return result;
        }
    }
}
