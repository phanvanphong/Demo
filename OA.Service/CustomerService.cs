using AutoMapper;
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
        private IRepository<Customer> customerRepository;

        public CustomerService(IRepository<Customer> customerRepository)
        {
            this.customerRepository = customerRepository;
        }
        public void Delete(long id)
        {
            Customer customer = customerRepository.Get(id);

            customerRepository.Delete(customer);
            //customerRepository.Remove(customer);
            //customerRepository.SaveChanges();
        }

        public Customer GetId(int id)
        {
          return customerRepository.Get(id);
        }

        //public IQueryable<Customer> GetList()
        //{
        //    return customerRepository.GetAll();
        //}

        public int Count()
        {
            return customerRepository.GetAll().Count();
        }

        public void Insert(string username, string password, string fullname, string address, string email, string createdat, int userprofileid)
        {
            var customer = new Customer(username, password, fullname, address, email, createdat, userprofileid);
            customerRepository.Insert(customer);
        }

        public void Update(int id, string username, string password, string fullname, string address, string email, string createdat, int userprofileid)
        {
            var customer = customerRepository.Get(id);
            customer.Modify(username, password, fullname, address, email, createdat, userprofileid);
            customerRepository.Update(customer);
        }

        public Pager<Customer> GetCustomers(string search, int currentPage, int pageSize)
        {
            if (search == null) search = "";
            var result = customerRepository.Paging(c => c.Username.Contains(search), currentPage, pageSize, u => u.UserProfile);
            return result;
        }
    }
}
