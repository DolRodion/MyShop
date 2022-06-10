using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MyWorkShop.Entities
{
    public class ShopServices : BaseEntity
    {
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
        public string DescriptionService{ get; set; }

        /// <summary>
        /// ID магазина
        /// </summary>
        public int ShopId { get; set; }

        [ForeignKey("ShopId")]
        public Shop Shop { get; set; }

        /// <summary>
        /// ID скидок
        /// </summary>
        public int? DiscountsId { get; set; }

        [ForeignKey("DiscountsId")]
        public Discounts Discounts { get; set; }
    }
}
