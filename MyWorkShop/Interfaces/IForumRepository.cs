using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyWorkShop.Entities;

namespace MyWorkShop.Interfaces
{
    public interface IForumRepository
    {
        List<Forum> GetAllForumMesseges();

        void AddNewMessage(Forum entity);
    }
}
