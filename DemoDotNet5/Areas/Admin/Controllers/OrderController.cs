using AutoMapper;
using DemoDotNet5.ViewModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using OA.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoDotNet5.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Policy = "ManagerStore")]
    public class OrderController : Controller
    {
        private readonly IOrderService _orderService;
        private readonly IOrderDetailService _orderDetailService;
        private readonly IMapper _mapper;
        public OrderController(IOrderService orderService, IOrderDetailService orderDetailService, IMapper mapper)
        {
            _orderService = orderService;
            _orderDetailService = orderDetailService;
            _mapper = mapper;
        }

        public async Task<IActionResult> Index(string search, int currentPage, int pageSize)
        {
            var data = await _orderService.GetOrders(search, currentPage, pageSize);
            var orders = data.Items;

            ViewBag.totalItems = await _orderService.Count();
            ViewBag.totalPages = data.TotalPages;
            ViewBag.currentPage = data.CurrentPage;
            ViewBag.search = search;
            ViewBag.pageSize = data.PageSize;

            var ordersViewModel = _mapper.Map<List<OrderViewModel>>(orders);
            return View(ordersViewModel);
        }

        public async Task<IActionResult> ShowOrderDetail(int id, int currentPage, int pageSize)
        {
            var data = await _orderDetailService.GetOrderDetails(id, currentPage, pageSize);
            var orderDetail = data.Items;

            ViewBag.totalItems = data.Items.Count();
            ViewBag.orderNumber = id;

            var orderDetailViewModel = _mapper.Map<List<OrderDetailViewModel>>(orderDetail);
            return View(orderDetailViewModel);
        }
    }
}
