using AutoMapper;
using DemoDotNet5.Data;
using DemoDotNet5.Models;
using DemoDotNet5.ViewModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using OA.Data;
using OA.Repo;
using OA.Service;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace DemoDotNet5.Controllers
{
   [Authorize(Policy ="ManagerStore")]
   [Route("Product/[action]/{id?}")]
    public class ProductController : Controller
    {
        private ICategoryService _categoryService;
        private IProductService _productService;
        private readonly IMapper _mapper;
        private readonly IWebHostEnvironment _hostEnvironment;

        public ProductController(IProductService productService ,IWebHostEnvironment hostEnvironment,IMapper mapper,ICategoryService categoryService)
        {
            _productService = productService;
            _mapper = mapper;
            _hostEnvironment = hostEnvironment;
            _categoryService = categoryService;
        }

        public IActionResult Index(string search, int currentPage, int pageSize)
        {
            var data = _productService.GetProducts(search, currentPage, pageSize);
            var products = data.Items;
            ViewBag.totalItems = _productService.Count();
            ViewBag.totalPages = data.TotalPages;
            ViewBag.currentPage = data.CurrentPage;
            ViewBag.search = search;
            ViewBag.pageSize = data.PageSize;

            var productViewModel = _mapper.Map<List<ProductViewModel>>(products);
            return View(productViewModel);
        }

        public IActionResult Create()
        {
            var categories = _categoryService.GetList();
            var categoryViewModel = _mapper.Map<List<CategoryViewModel>>(categories);
            ViewBag.cats = categoryViewModel;
            return View();
        }

        [ValidateAntiForgeryToken]
        [HttpPost]
        public IActionResult Create(ProductViewModel obj)
        {
            if (ModelState.IsValid)
            {
                string fileName = null;
                if (obj.FileUpload != null)
                {
                    // Tạo filename với chuỗi ký tự sinh ngẫu nhiên + tên fileimage
                    fileName = Guid.NewGuid().ToString() + "-" + obj.FileUpload.FileName;
                    // Tạo đường dẫn lưu trữ ảnh
                    var filePath = Path.Combine(_hostEnvironment.WebRootPath, "images", fileName);
                    // Tạo file lưu trữ và di chuyển ảnh đến thư mục lưu trữ
                    using var fileStream = new FileStream(filePath, FileMode.Create);
                    obj.FileUpload.CopyTo(fileStream);
                }

                var Product = new Product(obj.Name, obj.Price, obj.CategoryId, fileName);
                _productService.Insert(Product);
                return RedirectToAction("Index");
            }
            return View();
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var categories = _categoryService.GetList();
            var categoryViewModel = _mapper.Map<List<CategoryViewModel>>(categories);
            ViewBag.cats = categoryViewModel;

            var product = _productService.GetId(id);
            var productViewModel = _mapper.Map<ProductViewModel>(product);
            return View(productViewModel);
        }

        [ValidateAntiForgeryToken]
        [HttpPost]
        public IActionResult EditPost(ProductViewModel obj,int id)
        {
            var categories = _categoryService.GetList();
            var categoryViewModel = _mapper.Map<List<CategoryViewModel>>(categories);
            ViewBag.categories = categoryViewModel;

            var product = _productService.GetId(id);
            if (ModelState.IsValid)
            {
                // Lấy tên hình ảnh
                string fileName = product.Image;
                // Nếu FileEdit != null tức là người dùng chọn image mới để update
                if (obj.FileEdit != null)
                {
                    // Tiến hành lấy thông tin ảnh mới
                    fileName = Guid.NewGuid().ToString() + "-" + obj.FileEdit.FileName;
                    var filePath = Path.Combine(_hostEnvironment.WebRootPath, "images", fileName);
                    using var fileStream = new FileStream(filePath, FileMode.Create);
                    obj.FileEdit.CopyTo(fileStream);
                    product.Image = fileName;
                }
                // Nếu không thỳ vẫn lấy image cũ
                else
                {
                    product.Image = fileName;
                }
                product.Name = obj.Name;
                product.Price = obj.Price;
                product.CategoryId = obj.CategoryId;
                _productService.Update(product);

                return RedirectToAction("Index");
            }
            return View(obj);
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            _productService.Delete(id);
            return RedirectToAction("Index");
        }
    }
}
