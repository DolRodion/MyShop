using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyWorkShop.Interfaces;

namespace MyWorkShop.Controllers
{
    public class AdminController : Controller
    {
        private readonly ITransactionLogService transactionLogService;

        public AdminController(ITransactionLogService transactionLogService)
        {
            this.transactionLogService = transactionLogService;
        }

        public async Task<IActionResult> ViewTransactionLog()
        {
            var zapros = await transactionLogService.GetAllTransactionLogModelAsync();

            ViewBag.AllTransactionLog = zapros;

            return View();
        }

    }
}
