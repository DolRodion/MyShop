using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MyWorkShop.Entities;
using MyWorkShop.Enums;
using MyWorkShop.Helper;
using MyWorkShop.Interfaces;
using MyWorkShop.Models;
using MyWorkShop.Param;

namespace MyWorkShop.Services
{
    public class MaintenanceService : IMaintenanceService
    {
        private readonly IGenericRepository<ShopServices> shopServicesRepository;
        private readonly IGenericRepository<ServiceApplication> serviceApplicationRepository;

        public MaintenanceService(
            IGenericRepository<ShopServices> genericRepository , 
            IGenericRepository<ServiceApplication> serviceApplicationRepository
            )
        {
            this.shopServicesRepository = genericRepository;
            this.serviceApplicationRepository = serviceApplicationRepository;
        }

        public async Task<List<ShopServiceModel>> GetAllShopServicesAsync()
        {
            var entity = await shopServicesRepository.AsQueryable()
                .OrderByDescending(s => s.Id)
                .ToListAsync();

            List<ShopServiceModel> result = new List<ShopServiceModel>();

            foreach (var item in entity)
            {
                result.Add(
                    new ShopServiceModel()
                    {
                        Id = item.Id,
                        DescriptionService = item.DescriptionService,
                        PriceService = item.Discounts == null ? item.PriceService : PriceHelper.GetPriceWithDiscount(item.PriceService, item.Discounts),
                        ServicesName = item.ServicesName,
                        Discount = PriceHelper.IsDiscountExpired(item.Discounts)
                    }
                );
            }

            return result;
        }

        public async Task AddNewShopServiceAsync(ShopServicesParam param)
        {
            var entity = new ShopServices()
            {
                ServicesName = param.ServicesName,
                PriceService = param.PriceService,
                DescriptionService = param.DescriptionService,
                ShopId = 1
                
            };

            await shopServicesRepository.AddAsync(entity);
        }


        public async Task<ShortShopServiceModel> GetShopServiceByIdAsync(int id)
        {
            var entity = await shopServicesRepository.GetByIdAsync(id);

            ShortShopServiceModel result = new ShortShopServiceModel()
            {
                Id = entity.Id,
                ServiceName = entity.ServicesName,
                ServicePrice = entity.Discounts == null ? entity.PriceService : PriceHelper.GetPriceWithDiscount(entity.PriceService, entity.Discounts),
                DescriptionService = entity.DescriptionService
            };

            return result;
        }

        public async Task EditShopServiceAsync(ShopServicesParam param)
        {
            var entity = await shopServicesRepository.GetByIdAsync(param.Id);

            entity.ServicesName = param.ServicesName;
            entity.PriceService = param.PriceService;
            entity.DescriptionService = param.DescriptionService;

            await shopServicesRepository.SaveChangesAsync();
        }

        public async Task SendServiceApplicationAsync(ServiceApplicationParam param)
        {
            var entity = new ServiceApplication()
            {
                ApplicationData = DateTime.Now,
                Fio = param.Fio,
                Email = param.Email,
                Description = param.Description,
                Telephone = param.Telephone,
                ServiceStatusEnum = ServiceStatusEnum.InConsideration,
                ShopServicesId = param.Id
            };

            await serviceApplicationRepository.AddAsync(entity);
        }
    }
}
