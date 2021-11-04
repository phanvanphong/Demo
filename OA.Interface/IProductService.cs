using OA.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OA.Service
{
    public interface IProductService
    {
        // public IQueryable<Product> GetList();
        public Product GetId(int id);
        public int Count();
        public void Insert(Product product);
        public void Update(Product product);
        public void Delete(int id);
        public Task<Pager<Product>> GetProducts(string search, int currentPage, int pageSize);
    }
}
