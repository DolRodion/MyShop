using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using MyWorkShop.Enums;

namespace MyWorkShop.Models
{
    public class ShopProductModel
    {
        /// <summary>
        /// Id товара
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Путь к файлу
        /// </summary>
        public string FilePatch { get; set; }

        /// <summary>
        /// Название товара
        /// </summary>
        public string ProductName { get; set; }

        /// <summary>
        /// Вид товара
        /// </summary>
        public string TypeProdycts { get; set; }

        /// <summary>
        /// Наличие товара
        /// </summary>
        public bool IsAvaliable { get; set; }

        /// <summary>
        /// Цена товара
        /// </summary>
        public decimal PriceProduct { get; set; }

        /// <summary>
        /// Производитель товара
        /// </summary>
        public string ManufacturerProduct { get; set; }

        /// <summary>
        /// Описание товара
        /// </summary>
        public string DescriptionProduct { get; set; }

        /// <summary>
        /// Процент скидки
        /// </summary>
        public int Discount { get; set; }
    }
}
