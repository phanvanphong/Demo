using DemoDotNet5.ViewModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OA.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoDotNet5.Controllers
{
    public class CustomerController : Controller
    {
        private readonly ICategoryService _categoryService;
        private readonly ICustomerService _customerService;
        public CustomerController(ICategoryService categoryService,ICustomerService customerService)
        {
            _categoryService = categoryService;
            _customerService = customerService;
        }
        public IActionResult LoginCustomer()
        {
            var categories = _categoryService.GetList();
            ViewBag.categories = categories;

            CustomerViewModel customerViewModel = new CustomerViewModel();
            return View(customerViewModel);
        }
        
        [HttpPost]
        public async Task<IActionResult> CheckLoginCustomer(string username, string password)
        {
            var data = await _customerService.CheckLogin(username, password);
            if (data != null)
            {
                HttpContext.Session.SetInt32("customerId", data.Id);
                HttpContext.Session.SetString("username", data.Username);
                return RedirectToAction("Index", "Home");
            }
            return RedirectToAction("RegisterCustomer","Customer");
        }

        public IActionResult RegisterCustomer()
        {
            var categories = _categoryService.GetList();
            ViewBag.categories = categories;

            CustomerViewModel customerViewModel = new CustomerViewModel();
            return View(customerViewModel);
        }

        public IActionResult LogoutCustomer()
        {
            HttpContext.Session.Remove("customerId");
            HttpContext.Session.Remove("username");
            return RedirectToAction("Index", "Home");
        }
    }
}
