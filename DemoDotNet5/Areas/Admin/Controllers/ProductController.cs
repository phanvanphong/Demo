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

namespace DemoDotNet5.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Policy ="ManagerStore")]
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

        public async Task<IActionResult> Index(string search, int currentPage, int pageSize)
        {
            var data = await _productService.GetProducts(search, currentPage, pageSize);
            var products = data.Items;

            ViewBag.totalItems = await _productService.Count();
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
        public async Task<IActionResult> Create(ProductViewModel obj)
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
                await _productService.Insert(obj.Name, obj.Price, obj.CategoryId, fileName);
                return RedirectToAction("Index");
            }
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var categories = _categoryService.GetList();
            var categoryViewModel = _mapper.Map<List<CategoryViewModel>>(categories);
            ViewBag.cats = categoryViewModel;

            var product = await _productService.GetId(id);
            var productViewModel = _mapper.Map<ProductViewModel>(product);
            return View(productViewModel);
        }

        [ValidateAntiForgeryToken]
        [HttpPost]
        public async Task<IActionResult> EditPost(ProductViewModel obj,int id)
        {
            var categories = _categoryService.GetList();
            var categoryViewModel = _mapper.Map<List<CategoryViewModel>>(categories);
            ViewBag.categories = categoryViewModel;

            var product = await _productService.GetId(id);
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
                    obj.ImageName = fileName;
                }
                // Nếu không thỳ vẫn lấy image cũ
                else
                {
                    obj.ImageName = fileName;
                }
                //product.Name = obj.Name;
                //product.Price = obj.Price;
                //product.CategoryId = obj.CategoryId;

                await _productService.Update(id,obj.Name,obj.Price,obj.CategoryId,obj.ImageName);

                return RedirectToAction("Index");
            }
            return View(obj);
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            await _productService.Delete(id);
            return RedirectToAction("Index");
        }
    }
}
