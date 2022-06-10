using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyWorkShop.Param
{
    public class ShopServicesParam
    {
        /// <summary>
        /// Id
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
    }
}
