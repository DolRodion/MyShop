using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyWorkShop.AppData;
using MyWorkShop.Entities;
using MyWorkShop.Interfaces;

namespace MyWorkShop.Repository
{
    public class ForumRepository : IForumRepository
    {
        private readonly DbWorkShopContext DbWorkShopContext;
        public ForumRepository(DbWorkShopContext dbWorkShopContext)
        {
            DbWorkShopContext = dbWorkShopContext;
        }

        public List<Forum> GetAllForumMesseges()
        {
            var result = DbWorkShopContext.Forum.AsQueryable()
            .OrderByDescending(q => q.DateText)
            .ToList();

            return result;
        }

        public void AddNewMessage(Forum entity)
        {
            DbWorkShopContext.Forum.Add(entity);
            DbWorkShopContext.SaveChanges();
        }
    }
}
