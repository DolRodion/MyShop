using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyWorkShop.Entities;
using MyWorkShop.Models;
using MyWorkShop.Param;

namespace MyWorkShop.Interfaces
{
    public interface IProductService
    {
        Task<List<ShopProductModel>> GetAllShopProductsAsync(FilterParam param);

        Task AddNewShopProductAsync(ShopProductParam param);

        Task<ShopProductModel> GetShopProductByIdAsync(int id);

        Task EditShopProductAsync(ShopProductParam param);

        Task DeleteShopProductAsync(int id);

        Task<List<ShopProductModel>> GetShopProductsForMainPageAsync();

        Task<List<string>> GetAllManufacturerProduct();


    }
}
