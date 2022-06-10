using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyWorkShop.Enums;

namespace MyWorkShop.Models
{
    public class ShopServiceModel
    {
        /// <summary>
        /// Id услуги
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Название услуги
        /// </summary>
        public string ServicesName { get; set; }

        /// <summary>
        /// Цена услуги
        /// </summary>
        public decimal PriceService { get; set; }

        /// <summary>
        /// Описание услуги
        /// </summary>
        public string DescriptionService { get; set; }

        /// <summary>
        /// Процент скидки
        /// </summary>
        public int Discount { get; set; }
    }
}
