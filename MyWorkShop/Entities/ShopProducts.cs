using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;
using MyWorkShop.Enums;

namespace MyWorkShop.Entities
{
    /// <summary>
    /// Entity продуктов
    /// </summary>
    public class ShopProducts : BaseEntity
    {

        /// <summary>
        /// Название товара
        /// </summary>
        public string ProductName { get; set; }

        /// <summary>
        /// Вид товара
        /// </summary>
        public TypeProductsEnum TypeProdyctsEnum { get; set; }

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
        /// ID магазина
        /// </summary>
        public int ShopId { get; set; }

        [ForeignKey("ShopId")]
        public Shop Shop { get; set; }

        /// <summary>
        /// Список покупок
        /// </summary>
        public List<Purchases> Purchases { get; set; } = new List<Purchases>();

        /// <summary>
        /// ID скидок
        /// </summary>
        public int? DiscountsId { get; set; }

        [ForeignKey("DiscountsId")]
        public Discounts Discounts { get; set; }

        /// <summary>
        /// ID файла
        /// </summary>
        public int? FilesId { get; set; }

        [ForeignKey("FilesId")]
        public Files Files { get; set; }
    }
    
}
