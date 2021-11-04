using OA.Data;
using OA.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OA.Service
{
    public class ProductService : IProductService
    {
        private IRepository<Product> _productRepository;

        public ProductService(IRepository<Product> productRepository)
        {
            _productRepository = productRepository;
        }
        public void Delete(int id)
        {
            Product product = _productRepository.Get(id);
            _productRepository.Delete(product);

            //productRepository.Remove(product);
            //productRepository.SaveChanges();
        }

        public Product GetId(int id)
        {
            return _productRepository.Get(id);
        }

        public int Count()
        {
            return _productRepository.GetAll().Count();
        }

        //public IQueryable<Product> GetList()
        //{
        //    return productRepository.GetAll();
        //}

        public void Insert(Product product)
        {
            _productRepository.Insert(product);
        }

        public void Update(Product product)
        {
            _productRepository.Update(product);
        }

        public async Task<Pager<Product>> GetProducts(string search, int currentPage, int pageSize)
        {
            if (search == null) search = "";
            var result = await _productRepository.Paging(p => p.Name.Contains(search), currentPage, pageSize, c => c.Category);
            return result;
        }
    }
}
