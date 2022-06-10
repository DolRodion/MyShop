using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using MyWorkShop.Enums;

namespace MyWorkShop.Param
{
    public class ShopProductParam
    {
        /// <summary>
        /// Идентификатор записи
        /// </summary>
        public int Id { get; set; }

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
        public string IsAvaliable { get; set; }

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
        /// Загружаемый файл
        /// </summary>
        public IFormFile FormFile { get; set; }
    }
}
