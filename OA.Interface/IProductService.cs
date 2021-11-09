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
        public Task<Product> GetId(int id);
        public Task<int> Count();
        public Task Insert(string name, string price, int categoryId, string image);
        public Task Update(int id, string name, string price, int categoryId, string image);
        public Task Delete(int id);
        public Task<Pager<Product>> GetProducts(string search, int currentPage, int pageSize);
        public Task<IEnumerable<Product>> FeaturedProducts();
        public Task<IEnumerable<Product>> NewProducts();
        public Task<IEnumerable<Product>> RelatedProducts(int id);

    }
}
