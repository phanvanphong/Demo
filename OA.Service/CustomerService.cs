using AutoMapper;
using DemoDotNet5.Data;
using Microsoft.AspNetCore.Identity;
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
        public void Delete(long id)
        {
            Customer customer = _customerRepository.Get(id);

            _customerRepository.Delete(customer);
            //customerRepository.Remove(customer);
            //customerRepository.SaveChanges();
        }

        public Customer GetId(int id)
        {
          return _customerRepository.Get(id);
        }

        //public IQueryable<Customer> GetList()
        //{
        //    return customerRepository.GetAll();
        //}

        public int Count()
        {
            return _customerRepository.GetAll().Count();
        }

        public void Insert(string username, string password, string fullname, string address, string email, string createdat, int userprofileid)
        {
            var customer = new Customer(username, password, fullname, address, email, createdat, userprofileid);
            _customerRepository.Insert(customer);
        }

        public void Update(int id, string username, string password, string fullname, string address, string email, string createdat, int userprofileid)
        {
            var customer = _customerRepository.Get(id);
            customer.Modify(username, password, fullname, address, email, createdat, userprofileid);
            _customerRepository.Update(customer);
        }

        public async Task<Pager<Customer>> GetCustomers(string search, int currentPage, int pageSize)
        {
            if (search == null) search = "";
            var result = await _customerRepository.Paging(c => c.Username.Contains(search), currentPage, pageSize, u => u.UserProfile);
            return result;
        }

        public int GetUserProfileId(string id)
        {
            return _context.Users.Find(id).UserProfileId;
        }
    }
}
