using AutoMapper;
using DemoDotNet5.Data;
using DemoDotNet5.Models;
using DemoDotNet5.ViewModel;
using log4net;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Logging;
using OA.Data;
using OA.Service;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoDotNet5.Controllers
{
    [Authorize(Policy = "ManagerStore")]
    // Có thể khai báo Route ở Controller kết hợp với Phương thức
    public class CategoryController : Controller
    {
        private readonly ICategoryService _categoryService;
        private readonly IMapper _mapper;
        // Khai báo sử dụng log4net
        private static readonly ILog log = LogManager.GetLogger(typeof(CategoryController));
        // Khai báo sử dụng serilog
        private readonly ILogger<CategoryController> _logger;
        // Khai báo sử dụng memory cache
        private readonly IMemoryCache _memoryCache;

        public CategoryController(ICategoryService categoryService, IMapper mapper,ILogger<CategoryController> logger, IMemoryCache memoryCache)
        {
            _categoryService = categoryService;
            _mapper = mapper;
            _logger = logger;
            _memoryCache = memoryCache;
        }

        [HttpGet]
        public IActionResult Index(string search, int currentPage, int pageSize)
        {
            // Test sử dụng memory cache
            DateTime currentTime;
            bool AlreadyExit = _memoryCache.TryGetValue("CachedTime", out currentTime);
            if (!AlreadyExit)
            {
                currentTime = DateTime.Now;
                var cacheEntryOptions = new MemoryCacheEntryOptions()
                                        .SetSlidingExpiration(TimeSpan.FromSeconds(20));
                _memoryCache.Set("CachedTime", currentTime, cacheEntryOptions);
            }

            ViewBag.currentTime = currentTime;
            // Test log4net
            //int a = 10;
            //int b = 0;
            //try
            //{
            //    var total = a / b;
            //}catch(Exception e)
            //{
            //    log.Debug(e);
            //}

            var data = _categoryService.GetCategories(search, currentPage, pageSize);
            var categories = data.Items;

            ViewBag.totalItems = _categoryService.Count();
            ViewBag.totalPages = data.TotalPages;
            ViewBag.currentPage = data.CurrentPage;
            ViewBag.search = search;
            ViewBag.pageSize = data.PageSize;

            var categoryViewModel = _mapper.Map<List<CategoryViewModel>>(categories);
            return View(categoryViewModel);



            //List<Category> categories;
            //int totalCategory;
            //int totalPages;
            //if (!string.IsNullOrEmpty(search))
            //{

            //    // Đếm lại tổng số record trong categories
            //    totalCategory = categoryService.GetList().Where(c => c.Name.Contains(search)).Count();
            //    var pager = new Pager(totalCategory, currentPage, pageSize);
            //    totalPages = pager.TotalPages;
            //    categories = categoryService.GetList().Where(c => c.Name.Contains(search)).Skip(pager.StartPage).Take(pager.PageSize).ToList();
            //}
            //else
            //{
            //    totalCategory = categoryService.GetList().Count();
            //    var pager = new Pager(totalCategory, currentPage, pageSize);
            //    totalPages = pager.TotalPages;
            //    categories = categoryService.GetList().Skip(pager.StartPage).Take(pager.PageSize).ToList();
            //}

            ////var categories = categoryService.GetCategories(search, currentPage, pageSize);

            //ViewBag.totalPages = totalPages;
            //ViewBag.currentPage = currentPage;
            //ViewBag.search = search;
            //ViewBag.pageSize = pageSize;


            //var categoryViewModel = _mapper.Map<List<CategoryViewModel>>(categories);
            //return View(categoryViewModel);

        }


        public IActionResult Create()
        {
            CategoryViewModel categoryViewModel = new CategoryViewModel();
            return View(categoryViewModel);
        }

        [ValidateAntiForgeryToken]
        [HttpPost]
        public IActionResult Create(CategoryViewModel obj)
        {
            try
            {
                _categoryService.Insert(obj.Name, obj.Description);
            }
            catch (Exception e)
            {
                _logger.LogError("Error when insert category: {e}",e);
            }
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {

            var category = _categoryService.GetId(id);
            var categoryViewModel = _mapper.Map<CategoryViewModel>(category);
            return View(categoryViewModel);
        }

        [ValidateAntiForgeryToken]
        [HttpPost]
        public IActionResult EditPost(CategoryViewModel obj)
        {
            _categoryService.Update(obj.Id, obj.Name, obj.Description);
            return RedirectToAction("Index");
        }

        // Sử dụng serilog
        [HttpGet]
        public IActionResult Delete(int id)
        {
            try
            {
                _categoryService.Delete(id);
            }catch(Exception e)
            {
                _logger.LogError("Error when delete category: {e}",e);
            }
            return RedirectToAction("Index");
        }



        //// Sử dụng Log4net
        //[HttpGet]
        //public IActionResult Delete(int id)
        //{
        //    try
        //    {
        //        categoryService.Delete(id);
        //    }
        //    catch (Exception e)
        //    {
        //        log.Error(e);
        //    }
        //    return RedirectToAction("Index");
        //}
    }
}
