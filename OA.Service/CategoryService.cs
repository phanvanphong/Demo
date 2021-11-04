using Microsoft.Extensions.Caching.Memory;
using OA.Data;
using OA.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OA.Service
{
    public class CategoryService : ICategoryService
    {
        private IRepository<Category> _categoryRepository;
        public CategoryService(IRepository<Category> categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }
        public void Delete(long id)
        {
            Category category = _categoryRepository.Get(id);
            _categoryRepository.Delete(category);
            //categoryRepository.Remove(category);
            //categoryRepository.SaveChanges();
        }

        public int Count()
        {
            return _categoryRepository.GetAll().Count();
        }

        public IQueryable<Category> GetList()
        {
            return _categoryRepository.GetAll();
        }

        public Category GetId(int id)
        {
            return _categoryRepository.Get(id);
        }

        public void Insert(string name, string description)
        {
            var category = new Category(name,description);
            _categoryRepository.Insert(category);
        }

        public void Update(int id, string name, string description)
        {
            var category = _categoryRepository.Get(id);
            category.Modify(name, description);
            _categoryRepository.Update(category);
        }
        
        public async Task<Pager<Category>> GetCategories(string search,int currentPage, int pageSize)
        {

            if (search == null) search = "";
            var result = await _categoryRepository.Paging(c => c.Name.Contains(search), currentPage, pageSize);
            return result;

        }



        //public List<Category> Search(string search)
        //{
        //    if (search == null) search = "";
        //    List<Category> categories = categoryRepository.GetAll().Where(a => a.Name.Contains(search)).ToList();
        //    return categories;

        //}

        //public List<Category> GetCategories(string search, int currentPage, int pageSize)
        //{
        //    List<Category> categories;
        //    int totalCategory;
        //    int totalPages;
        //    if (!string.IsNullOrEmpty(search))
        //    {
        //        Đếm lại tổng số record trong categories
        //       totalCategory = categoryRepository.GetAll().Where(c => c.Name.Contains(search)).Count();
        //        var pager = new Pager(totalCategory, currentPage, pageSize);
        //        totalPages = pager.TotalPages;
        //        categories = categoryRepository.GetAll().Where(c => c.Name.Contains(search)).Skip(pager.StartPage).Take(pager.PageSize).ToList();
        //    }
        //    else
        //    {
        //        totalCategory = categoryRepository.GetAll().Count();
        //        var pager = new Pager(totalCategory, currentPage, pageSize);
        //        totalPages = pager.TotalPages;
        //        categories = categoryRepository.GetAll().Skip(pager.StartPage).Take(pager.PageSize).ToList();
        //    }

        //}



        //    //ViewBag.totalPages = totalPages;
        //    //ViewBag.currentPage = currentPage;
        //    //ViewBag.search = search;
        //    //ViewBag.pageSize = pageSize;


        //    //if (search == null) search = "";
        //    //var totalCategory = categoryRepository.GetAll().Where(a => a.Name.Contains(search)).Count();
        //    //var pager = new Pager(totalCategory, currentPage, pageSize);


        //    return categories;

        //}

    }
}
