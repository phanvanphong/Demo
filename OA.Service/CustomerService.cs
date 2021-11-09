using AutoMapper;
using DemoDotNet5.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using OA.Data;
using OA.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OA.Service
{
    public class CustomerService : ICustomerService
    {
        private IRepository<Customer> _customerRepository;
        private readonly EShopDbContext _context;

        public CustomerService(IRepository<Customer> customerRepository,EShopDbContext context)
        {
            _customerRepository = customerRepository;
            _context = context;
        }
        public async Task Delete(long id)
        {
            Customer customer = await _customerRepository.Get(id);

            await _customerRepository.Delete(customer);
            //customerRepository.Remove(customer);
            //customerRepository.SaveChanges();
        }

        public async Task<Customer> GetId(int id)
        {
          return await _customerRepository.Get(id);
        }

        public async Task<int> Count()
        {
            return await _customerRepository.Count();
        }

        public async Task Insert(string username, string password, string fullname, string address, string email, string createdat, int userprofileid)
        {
            var customer = new Customer(username, password, fullname, address, email, createdat, userprofileid);
            await _customerRepository.Insert(customer);
        }

        public async Task Update(int id, string username, string password, string fullname, string address, string email, string createdat, int userprofileid)
        {
            var customer = await _customerRepository.Get(id);
            customer.Modify(username, password, fullname, address, email, createdat, userprofileid);
            await _customerRepository.Update(customer);
        }

        public async Task<Pager<Customer>> GetCustomers(string search, int currentPage, int pageSize)
        {
            if (search == null) search = "";
            var result = await _customerRepository.Paging(c => c.Username.Contains(search), currentPage, pageSize, u => u.UserProfile);
            return result;
        }

        public async Task<int> GetUserProfileId(string id)
        {
            var user = await _context.Users.FindAsync(id);
            return user.UserProfileId;
        }

        public async Task<Customer> CheckLogin(string username, string password)
        {
            var data = await _customerRepository.GetAll().Where(c => c.Username.Equals(username) && c.Password.Equals(password)).FirstOrDefaultAsync();
            return data;
        }
    }
}
