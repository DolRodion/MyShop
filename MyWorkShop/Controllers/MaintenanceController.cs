using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyWorkShop.Interfaces;
using MyWorkShop.Param;

namespace MyWorkShop.Controllers
{
    public class MaintenanceController : Controller
    {
        private readonly IMaintenanceService maintenancetService;

        public MaintenanceController(IMaintenanceService maintenanceService)
        {
            this.maintenancetService = maintenanceService;
        }

        public async Task<IActionResult> ShopService()
        {
            var zapros = await maintenancetService.GetAllShopServicesAsync();

            ViewBag.NePetyh = zapros;

            return View();
        }

        [HttpGet]
        public  IActionResult AddShopService()
        {
            return View();
        }

       [HttpPost]
        public async Task<IActionResult> AddShopService(ShopServicesParam param)
        {
            await maintenancetService.AddNewShopServiceAsync(param);

            return RedirectToAction("ShopService");
        }

        [HttpGet]
        public async Task<IActionResult> EditShopService(int id)
        {
            var zapros = await maintenancetService.GetShopServiceByIdAsync(id);
            ViewBag.Data = zapros;
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> EditShopService(ShopServicesParam param)
        {
            await maintenancetService.EditShopServiceAsync(param);

            return RedirectToAction("ShopService");
        }

        [HttpGet]
        public async Task<IActionResult> OrderShopService(int id)
        {
            var zapros = await maintenancetService.GetShopServiceByIdAsync(id);
            ViewBag.Data = zapros;
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> OrderShopService(ServiceApplicationParam param)
        {
            await maintenancetService.SendServiceApplicationAsync(param);

            return RedirectToAction("ShopService");
        }

    }
}
