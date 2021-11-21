using AutoMapper;
using DemoDotNet5.ViewModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using OA.Data;
using OA.Interface;
using OA.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoDotNet5.Controllers
{
    public class CheckoutController : Controller
    {
        private readonly ICustomerService _customerService;
        private readonly IOrderService _orderService;
        private readonly IOrderDetailService _orderDetailService;
        private readonly IMapper _mapper;
        public CheckoutController(ICustomerService customerService,IOrderService orderService, IOrderDetailService orderDetailService, IMapper mapper)
        {
            _customerService = customerService;
            _orderService = orderService;
            _orderDetailService = orderDetailService;
            _mapper = mapper;
        }
        public async Task<IActionResult> Index()
        {
            // Lấy lại thông tin giỏ hàng
            var cart = HttpContext.Session.GetString("cart");
            if(cart != null)
            {
                List<CartItemViewModel> dataCart = JsonConvert.DeserializeObject<List<CartItemViewModel>>(cart);
                if(dataCart.Count > 0)
                {
                    ViewBag.carts = dataCart;
                }
                else
                {
                    ViewBag.carts = null;
                }
            }

            // Lấy lại thông tin khách hàng
            var customerId = HttpContext.Session.GetInt32("customerId");
            var customer = await _customerService.GetId((int)customerId);
            var customerViewModel = _mapper.Map<CustomerViewModel>(customer);
            ViewBag.customerViewModel = customerViewModel;

            return View();
        }



        [HttpPost]
        public async Task<IActionResult> PostCheckout(int customerId, string address, string notes)
        {
            // Thêm dữ liệu vào bảng order
            string date = Convert.ToString(DateTime.Now); // convert về kiểu string
            int status = 0;  // Mặc định = 0
            var order = await _orderService.Insert(date, notes, address, status, customerId);

            var orderId = order.Id; // Lấy orderId vừa insert
            var cart = HttpContext.Session.GetString("cart"); // Lấy lại danh sách cart
            List<CartItemViewModel> dataCart = JsonConvert.DeserializeObject<List<CartItemViewModel>>(cart);
            
            // Thêm dữ liệu vào bảng orderDetail
            foreach(var item in dataCart)
            {
               await _orderDetailService.Insert(item.Quantity, item.Product.Price, orderId, item.Product.Id); 
            }

            return RedirectToAction("Index", "Home");
        }
    }
}
