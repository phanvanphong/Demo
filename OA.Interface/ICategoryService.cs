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
        public IEnumerable<Category> GetList();
        public Task<int> Count();
        // Lấy Category theo id
        public Task<Category> GetId(int id);
        public Task Insert(string name, string description);
        public Task Update(int id, string name, string description);
        public Task Delete(long id);
        public Task<Pager<Category>> GetCategories(string search, int currentPage, int pageSize);
        //public List<Category> Search(string search);

    }
}
