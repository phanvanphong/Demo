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
        public int Count();
        // Lấy Customer theo id
        public Customer GetId(int id);
        public int GetUserProfileId(string id);
        public void Insert(string username, string password, string fullname, string address, string email, string createdat, int userprofileid);
        public void Update(int id, string username, string password, string fullname, string address, string email, string createdat, int userprofileid);
        public void Delete(long id);
        public Task<Pager<Customer>> GetCustomers(string search, int currentPage, int pageSize);
    }
}
