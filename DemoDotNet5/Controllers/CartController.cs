using AutoMapper;
using DemoDotNet5.Data;
using DemoDotNet5.ViewModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using OA.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoDotNet5.Controllers
{
    public class CartController : Controller
    {
        private readonly IProductService _productService;
        private readonly IMapper _mapper;
        public CartController(IProductService productService,IMapper mapper)
        {
            _productService = productService;
            _mapper = mapper;
        }


        public IActionResult Index()
        {
            var cart = HttpContext.Session.GetString("cart");
            if (cart != null)
            {
                List<CartItemViewModel> dataCart = JsonConvert.DeserializeObject<List<CartItemViewModel>>(cart);
                if (dataCart.Count > 0)
                {
                    ViewBag.carts = dataCart;
                }
            }
            else
            {
                ViewBag.carts = null;
            };
            return View();
        }




        public async Task<IActionResult> AddToCart(int id, int quantity = 1)
        {
            // Tạo biến cart để lấy session cart hiện có
            var cart = HttpContext.Session.GetString("cart");
            // Check nếu cart rỗng thỳ tạo đối tượng mới có kiểu List<CartItemViewModel> và lưu giá trị Product và Quantity = 1 
            if (cart == null)
            {
                var product = await _productService.GetId(id);
                var productViewModel = _mapper.Map<ProductViewModel>(product);
                List<CartItemViewModel> listCart = new List<CartItemViewModel>()
                {
                    new CartItemViewModel
                    {
                        Product = productViewModel,
                        Quantity = quantity
                    }
                };
                // JsonConvert.SerializeObject : chuyển đổi đối tượng thành chuỗi JSON
                // Lưu listCart vào session cart
                HttpContext.Session.SetString("cart", JsonConvert.SerializeObject(listCart));
            }
            // Check nếu tồn tại cart
            else
            {
                // JsonConvert.DeserializeObject : chuyển đổi chuỗi JSON thành đối tượng
                List<CartItemViewModel> dataCart = JsonConvert.DeserializeObject<List<CartItemViewModel>>(cart);
                // Đã tồn tại sản phẩm thỳ cộng số lượng và check = false
                bool check = true;
                for (int i = 0; i < dataCart.Count; i++)
                {
                    if (dataCart[i].Product.Id == id)
                    {
                        dataCart[i].Quantity++;
                        check = false;
                    }
                }
                // check = true tức là chưa tồn tại sản phẩm thỳ tạo đối tượng mới có kiểu List<CartItemViewModel> và lưu giá trị Product và Quantity = 1 
                if (check)
                {
                    var product = await _productService.GetId(id);
                    var productViewModel = _mapper.Map<ProductViewModel>(product);
                    dataCart.Add(new CartItemViewModel
                    {
                        Product = productViewModel,
                        Quantity = 1
                    });
                }
                // JsonConvert.SerializeObject : chuyển đổi đối tượng thành chuỗi JSON
                // Lưu dataCart vào session cart
                HttpContext.Session.SetString("cart", JsonConvert.SerializeObject(dataCart));
            }


            // Đếm lại số lượng trong cart sau đó trả về Json
            var getCart = HttpContext.Session.GetString("cart");
            List<CartItemViewModel> getListCart = JsonConvert.DeserializeObject<List<CartItemViewModel>>(getCart);
            if(getListCart != null)
            {
                return Json(new
                {
                    totalItems = getListCart.Sum(c => c.Quantity)
                });
            } 
            
            return RedirectToAction("Index", "Cart");
        }




        public async Task<IActionResult> DeleteCart(int id)
        {
            var cart = HttpContext.Session.GetString("cart");
            if (cart != null)
            {
                List<CartItemViewModel> dataCart = JsonConvert.DeserializeObject<List<CartItemViewModel>>(cart);
                for (int i = 0; i < dataCart.Count; i++)
                {
                    if (dataCart[i].Product.Id == id)
                    {
                        dataCart.Remove(dataCart[i]);
                    }
                }
                HttpContext.Session.SetString("cart", JsonConvert.SerializeObject(dataCart));
            }

            // Đếm lại số lượng trong cart sau đó trả về Json
            var getCart = HttpContext.Session.GetString("cart");
            List<CartItemViewModel> getListCart = JsonConvert.DeserializeObject<List<CartItemViewModel>>(getCart);
            var product = await _productService.GetId(id);

            // Tính lại tổng tiền giỏ hàng
            var subTotal = getListCart.Sum(c => c.Quantity * c.Product.Price);

            if (getListCart != null)
            {
                return Json(new
                {
                    totalItems = getListCart.Sum(c => c.Quantity),
                    // Tổng tiền giỏ hàng
                    subTotal = String.Format("{0:n0}", subTotal)
                });
            }

            return RedirectToAction("Index", "Cart");
        }






        public async Task<IActionResult> UpdateCart(int productId, int quantity)
        {
            var cart = HttpContext.Session.GetString("cart");
            if(cart != null)
            {
                List<CartItemViewModel> dataCart = JsonConvert.DeserializeObject<List<CartItemViewModel>>(cart);
                if(quantity > 0)
                {
                    for(int i = 0; i < dataCart.Count; i++)
                    {
                        if(dataCart[i].Product.Id == productId)
                        {
                            dataCart[i].Quantity = quantity;
                        }
                    }
                    HttpContext.Session.SetString("cart", JsonConvert.SerializeObject(dataCart));
                }
            }

            // Đếm lại số lượng trong cart sau đó trả về Json
            var getCart = HttpContext.Session.GetString("cart");
            List<CartItemViewModel> getListCart = JsonConvert.DeserializeObject<List<CartItemViewModel>>(getCart);
            var product = await _productService.GetId(productId);

            // Tính lại tổng tiền giỏ hàng
            var subTotal = getListCart.Sum(c => c.Quantity * c.Product.Price);

            if (getListCart != null)
            {
                return Json(new
                {
                    totalItems = getListCart.Sum(c => c.Quantity),
                    // Tổng tiền của 1 item cart
                    total = String.Format("{0:n0}", product.Price * quantity),
                    // Tổng tiền giỏ hàng
                    subTotal = String.Format("{0:n0}", subTotal)
                });
            }
            return RedirectToAction("Index", "Cart");
        }

    }
}
