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
        public async Task Delete(int id)
        {
            Product product = await _productRepository.Get(id);
            await _productRepository.Delete(product);

            //productRepository.Remove(product);
            //productRepository.SaveChanges();
        }

        public async Task<Product> GetId(int id)
        {
            return await _productRepository.Get(id);
        }

        public async Task<int> Count()
        {
            return await _productRepository.Count();
        }

        public async Task Insert(string name, double price, int categoryId, string image)
        {
            var product = new Product(name, price, categoryId, image);
            await _productRepository.Insert(product);
        }

        public async Task Update(int id, string name, double price, int categoryId, string image)
        {
            var product = await _productRepository.Get(id);
            product.Modify(name, price, categoryId, image);
            await _productRepository.Update(product);
        }

        public async Task<Pager<Product>> GetProducts(string search, int currentPage, int pageSize)
        {
            if (search == null) search = "";
            var result = await _productRepository.Paging(p => p.Name.Contains(search), currentPage, pageSize, c => c.Category);
            return result;
        }

        public async Task<IEnumerable<Product>> FeaturedProducts()
        {
            var newProducts = await _productRepository.SelectData(p => p.Price < 300000, p => p.Id ,c => c.Category);
            return newProducts;
        }

        public async Task<IEnumerable<Product>> NewProducts()
        {
            var newProducts = await _productRepository.SelectData(p => p.Price > 300000, p => p.Id ,c => c.Category);
            return newProducts;
        }

        public async Task<IEnumerable<Product>> RelatedProducts(int id)
        {
            var relatedProducts = await _productRepository.SelectData(p => p.CategoryId == id, p => p.Id, c => c.Category);
            return relatedProducts;
        }
    }
}

