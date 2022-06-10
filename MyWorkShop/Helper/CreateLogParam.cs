using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyWorkShop.Entities;
using MyWorkShop.Param;

namespace MyWorkShop.Helper
{
    public class CreateLogParam
    { 
        public static SaveLogParam GetParamForShopProducts(ShopProducts shopProducts)
        {
            SaveLogParam saveLogParam = new SaveLogParam()
            {
                OperationDate = DateTime.Now,
                Fio = "Admin",
                Data = $"Название товара - {shopProducts.ProductName}/ Производитель товара - {shopProducts.ManufacturerProduct}/ Цена товара - {shopProducts.PriceProduct}"
            };

            
            return saveLogParam;
        }
    }
}
