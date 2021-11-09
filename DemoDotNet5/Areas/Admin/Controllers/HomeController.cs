using DemoDotNet5.Models;
using log4net;
using log4net.Config;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace DemoDotNet5.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private static readonly ILog log = LogManager.GetLogger(typeof(HomeController));
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            // Test log4net
            // Nếu level = INFO thì chỉ log được từ INFO trở đi cụ thể dưới đây
            // là WARN và INFO.
            // log.Warn("Warn");
            // log.Debug("Debug");
            // log.Info("Info");

            // Test serilog
            // _logger.LogError("Error");
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
