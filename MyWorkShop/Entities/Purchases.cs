using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MyWorkShop.Entities
{
    public class Purchases : BaseEntity
    {
        /// <summary>
        /// Id покупателя
        /// </summary>
        public int BuyersId { get; set; }

        [ForeignKey("BuyersId")]
        public Buyers Buyers { get; set; }

        /// <summary>
        /// Список товаров
        /// </summary>
        public List<ShopProducts> ShopProducts { get; set; } = new List<ShopProducts>();

        /// <summary>
        /// Дата покупки
        /// </summary>
        public DateTime DatePurchases { get; set; }
    }
}
