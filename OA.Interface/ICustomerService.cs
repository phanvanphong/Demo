using OA.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace OA.Service
{
    public interface ICustomerService
    {
        // Lấy danh sách Customer
        // public IQueryable<Customer> GetList();
        public Task<int> Count();
        // Lấy Customer theo id
        public Task<Customer> GetId(int id);
        public Task<int> GetUserProfileId(string id);
        public Task Insert(string username, string password, string fullname, string address, string email, string createdat, int userprofileid);
        public Task Update(int id, string username, string password, string fullname, string address, string email, string createdat, int userprofileid);
        public Task Delete(long id);
        public Task<Pager<Customer>> GetCustomers(string search, int currentPage, int pageSize);
    }
}
