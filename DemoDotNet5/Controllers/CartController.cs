using Microsoft.AspNetCore.Mvc;
using OA.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoDotNet5.Controllers
{
    public class CartController : Controller
    {
        private readonly ICategoryService _categoryService;
        private readonly ICustomerService _customerService;
        public CartController(ICategoryService categoryService, ICustomerService customerService)
        {
            _categoryService = categoryService;
            _customerService = customerService;
        }
        public IActionResult Index()
        {
            var categories = _categoryService.GetList();
            ViewBag.categories = categories;

            return View();
        }
    }
}
