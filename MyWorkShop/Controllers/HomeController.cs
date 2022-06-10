using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MyWorkShop.AppData;
using MyWorkShop.Interfaces;
using MyWorkShop.Moq;
using MyWorkShop.Param;

namespace MyWorkShop.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProductService productService;

        public HomeController(IProductService productService)
        {
            this.productService = productService;
        }

        public async Task<IActionResult> Index()
        {
            var zapros = await productService.GetShopProductsForMainPageAsync();

            ViewBag.Main = zapros;
            return View();
        }
    }
}
