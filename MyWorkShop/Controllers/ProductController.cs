using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyWorkShop.Interfaces;
using MyWorkShop.Param;

namespace MyWorkShop.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService productService;

        public ProductController(IProductService productService)
        {
            this.productService = productService;
        }

        public async Task<IActionResult> ShopProductAdmin()
        {
            var zapros = await productService.GetAllShopProductsAsync(new FilterParam());
            ViewBag.ProductList = zapros;
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> ShopProducts()
        {
            var zapros = await productService.GetAllShopProductsAsync(new FilterParam());
            var manufacturers = await productService.GetAllManufacturerProduct();

            ViewBag.Petyh = zapros;
            ViewBag.Manufacturer = manufacturers;

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> ShopProducts(FilterParam param)
        {
            var zapros = await productService.GetAllShopProductsAsync(param);
            var manufacturers = await productService.GetAllManufacturerProduct();

            ViewBag.Petyh = zapros;
            ViewBag.Manufacturer = manufacturers;

            return View();
        }


        public async Task<IActionResult> DeleteShopProduct(int id)
        {
            await productService.DeleteShopProductAsync(id);

            return RedirectToAction("ShopProductAdmin");
        }

        [HttpGet]
        public IActionResult AddShopProducts()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddShopProducts(ShopProductParam param)
        {
            await productService.AddNewShopProductAsync(param);

            return RedirectToAction("ShopProducts");
        }

        [HttpGet]
        public async Task<IActionResult> EditShopProduct(int id)
        {
            var zapros = await productService.GetShopProductByIdAsync(id);

            ViewBag.Dom = zapros;

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> EditShopProduct(ShopProductParam param)
        {
            await productService.EditShopProductAsync(param);

            return RedirectToAction("ShopProductAdmin");
        }

        [HttpGet]
        public async Task<IActionResult> ViewShopProduct(int id)
        {
            var zapros = await productService.GetShopProductByIdAsync(id);

            ViewBag.View = zapros;

            return View();
        }

    }
}
