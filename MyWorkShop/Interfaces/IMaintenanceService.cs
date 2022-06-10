using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyWorkShop.Models;
using MyWorkShop.Param;

namespace MyWorkShop.Interfaces
{
    public interface IMaintenanceService
    {
        Task<List<ShopServiceModel>> GetAllShopServicesAsync();

        Task<ShortShopServiceModel> GetShopServiceByIdAsync(int id);
        Task SendServiceApplicationAsync(ServiceApplicationParam param);

        Task AddNewShopServiceAsync(ShopServicesParam param);

        Task EditShopServiceAsync(ShopServicesParam param);
    }
}
