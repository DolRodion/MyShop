using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyWorkShop.Interfaces;
using MyWorkShop.Param;

namespace MyWorkShop.Controllers
{
    public class ForumController : Controller
    {
        private readonly IForumService forumService;

        public ForumController(IForumService forumService)
        {
            this.forumService = forumService;
        }

        public async Task<IActionResult> Messege()
        {
            var zapros = await forumService.GetAllForumMessegesAsync();

            ViewBag.AllForumMesseges = zapros;

            return View();
        }

        public async Task<IActionResult> AddNewMessage(ForumMessegeParam param)
        {
            await forumService.AddNewMessage(param);

            return RedirectToAction("Messege");
        }
    }
}
