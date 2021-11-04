using DemoDotNet5.Models;
using DemoDotNet5.ViewModel;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using DemoDotNet5.Data;
using OA.Data;
using OA.Service;

namespace DemoDotNet5.Controllers
{
    [Authorize(Policy = "ManagerStore")]

    [Route("Admin/Customer/[action]/{id?}")]
    public class CustomerController : Controller
    {

        private readonly ICustomerService _customerService;
        private readonly IMapper _mapper;
        private readonly UserManager<ApplicationUser> _userManager;

        public CustomerController(ICustomerService customerService,IMapper mapper,UserManager<ApplicationUser> userManager)
        {
            _customerService = customerService;
            _mapper = mapper;
            _userManager = userManager;
        }

        [HttpGet]
        public async Task<IActionResult> Index(string search, int currentPage, int pageSize)
        {
            var data = await _customerService.GetCustomers(search, currentPage, pageSize);
            var customers = data.Items;

            ViewBag.totalItems = await _customerService.Count();
            ViewBag.totalPages = data.TotalPages;
            ViewBag.currentPage = data.CurrentPage;
            ViewBag.search = search;
            ViewBag.pageSize = data.PageSize;

            var customerViewModel = _mapper.Map<List<CustomerViewModel>>(customers);
            return View(customerViewModel);
        }

        public async Task<IActionResult> Create()
        {
            int userProfileId = await _customerService.GetUserProfileId(_userManager.GetUserId(User));
            ViewBag.userProfileId = userProfileId;

            CustomerViewModel customerViewModel = new CustomerViewModel();
            return View(customerViewModel);
        }

        [ValidateAntiForgeryToken]
        [HttpPost]
        public async Task<IActionResult> Create(CustomerViewModel customer)
        {
            await _customerService.Insert(customer.Username, customer.Password, customer.Fullname, customer.Address, customer.Email, customer.CreatedAt, customer.UserProfileId);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var customer = await _customerService.GetId(id);
            var customerViewModel = _mapper.Map<CustomerViewModel>(customer);
            return View(customerViewModel);
        }

        [ValidateAntiForgeryToken]
        [HttpPost]
        public async Task<IActionResult> EditPost(CustomerViewModel obj)
        {
            await _customerService.Update(obj.Id, obj.Username, obj.Password, obj.Fullname, obj.Address, obj.Email, obj.CreatedAt, obj.UserProfileId);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Delete(int id)
        {
            await _customerService.Delete(id);
            return RedirectToAction("Index");
        }
    }
}
