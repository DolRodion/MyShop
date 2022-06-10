using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MyWorkShop.Entities
{
    /// <summary>
    /// Entity магазина
    /// </summary>
    public class Shop : BaseEntity
    {
        /// <summary>
        /// Название магазина
        /// </summary>
        public string ShopName { get; set; }

        /// <summary>
        /// Телефон магазина
        /// </summary>
        public string ShopPhone { get; set; }

        /// <summary>
        /// Адрес магазина
        /// </summary>
        public string ShopAdress { get; set; }
    }
}
