using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MyWorkShop.Entities;
using MyWorkShop.Interfaces;
using MyWorkShop.Models;
using MyWorkShop.Param;

namespace MyWorkShop.Services
{
    public class ForumService : IForumService
    {
        private readonly IGenericRepository<Forum> forumRepository;

        public ForumService(IGenericRepository<Forum> genericRepository)
        {
            this.forumRepository = genericRepository;
        }

        public async Task<List<ForumMessegeModel>> GetAllForumMessegesAsync()
        {
            var entity = await forumRepository.AsQueryable()
                .OrderByDescending(s => s.Id)
                .ToListAsync();

            List<ForumMessegeModel> forumMessegeModel = new List<ForumMessegeModel>();

            foreach (var item in entity)
            {
                forumMessegeModel.Add(
                    new ForumMessegeModel()
                    {
                        Fio = item.Fio,
                        Text = item.Text,
                        DateText = item.DateText
                    }
                );

            }

            return forumMessegeModel;
        }

        public async Task AddNewMessage(ForumMessegeParam param)
        {
            var entity = new Forum()
            {
                Fio = param.Fio,
                DateText = DateTime.Now,
                ShopId = 1,
                Text = param.Text
            };

            await forumRepository.AddAsync(entity);
        }
    }
}
