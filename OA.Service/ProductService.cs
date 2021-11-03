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
        private IRepository<Product> productRepository;

        public ProductService(IRepository<Product> productRepository)
        {
            this.productRepository = productRepository;
        }
        public void Delete(int id)
        {
            Product product = productRepository.Get(id);
            productRepository.Delete(product);

            //productRepository.Remove(product);
            //productRepository.SaveChanges();
        }

        public Product GetId(int id)
        {
            return productRepository.Get(id);
        }

        public int Count()
        {
            return productRepository.GetAll().Count();
        }

        //public IQueryable<Product> GetList()
        //{
        //    return productRepository.GetAll();
        //}

        public void Insert(Product product)
        {
            productRepository.Insert(product);
        }

        public void Update(Product product)
        {
            productRepository.Update(product);
        }

        public Pager<Product> GetProducts(string search, int currentPage, int pageSize)
        {
            if (search == null) search = "";
            var result = productRepository.Paging(p => p.Name.Contains(search), currentPage, pageSize, c => c.Category);
            return result;
        }
    }
}
