using OA.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OA.Service
{
    public interface ICategoryService
    {
        // Lấy danh sách Category
        public IQueryable<Category> GetList();
        public int Count();
        // Lấy Category theo id
        public Category GetId(int id);
        public void Insert(string name, string description);
        public void Update(int id, string name, string description);
        public void Delete(long id);
        public Task<Pager<Category>> GetCategories(string search, int currentPage, int pageSize);
        //public List<Category> Search(string search);

    }
}
