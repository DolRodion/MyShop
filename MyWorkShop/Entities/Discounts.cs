using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MyWorkShop.Entities
{
    public class Discounts : BaseEntity
    {
        /// <summary>
        /// Процент скидки
        /// </summary>
        public int Discount { get; set; }

        /// <summary>
        /// Наличие скидки
        /// </summary>
        public bool DiscountAvailability { get; set; }

        /// <summary>
        /// Дата начала скидки
        /// </summary>
        public DateTime DateStart{ get; set; }

        /// <summary>
        /// Дата конца скидки
        /// </summary>
        public DateTime? DateEnd { get; set; }
    } 
}
