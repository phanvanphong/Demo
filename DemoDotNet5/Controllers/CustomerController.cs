using DemoDotNet5.ViewModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using OA.Service;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace DemoDotNet5.Controllers
{
    public class CustomerController : Controller
    {
        private readonly ICustomerService _customerService;
        private readonly IConfiguration _configuration;
        public CustomerController(ICustomerService customerService, IConfiguration configuration)
        {
            _customerService = customerService;
            _configuration = configuration;

        }
        public IActionResult LoginCustomer()
        {
            CustomerViewModel customerViewModel = new CustomerViewModel();
            return View(customerViewModel);
        }
        
        [HttpPost]
        public async Task<IActionResult> CheckLoginCustomer(string username, string password)
        {
            var data = await _customerService.CheckLogin(username, password);
            if (data != null)
            {
                // Lưu thông tin đăng nhập với Session
                HttpContext.Session.SetInt32("customerId", data.Id);
                HttpContext.Session.SetString("username", data.Username);

                // Tạo ra claims list (tức là các thông tin đính kèm ở trong Token)
                //var claims = new[]
                //{
                //    new Claim("Name", data.Username),
                //    new Claim("Email", data.Email)
                //};
                //var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["JwtSecurityKey"]));
                //var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
                //var expriry = DateTime.Now.AddDays(Convert.ToInt32(_configuration["JwtExpriryInDays"]));

                //var token = new JwtSecurityToken(
                //    _configuration["JwtIssuer"],
                //    _configuration["JwtAudience"],
                //    claims,
                //    expires: expriry,
                //    signingCredentials: creds
                //);

                //Ok(new CustomerViewModel { Token = new JwtSecurityTokenHandler().WriteToken(token) });
                //return RedirectToAction("Index", "Home");

                return RedirectToAction("Index", "Home");
            }
            return RedirectToAction("LoginCustomer", "Customer");
        }

        public IActionResult RegisterCustomer()
        {
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
