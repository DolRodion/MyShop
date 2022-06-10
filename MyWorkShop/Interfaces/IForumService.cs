using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyWorkShop.Models;
using MyWorkShop.Param;

namespace MyWorkShop.Interfaces
{
    public interface IForumService
    {
        Task<List<ForumMessegeModel>> GetAllForumMessegesAsync();

        Task AddNewMessage(ForumMessegeParam param);
    }
}
