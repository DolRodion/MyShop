using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MyWorkShop.Entities
{
    public class Forum : BaseEntity
    {
        /// <summary>
        /// Текст записи
        /// </summary>
        public string Text { get; set; }

        /// <summary>
        /// Фио
        /// </summary>
        public string Fio { get; set; }

        /// <summary>
        /// Дата записи
        /// </summary>
        public DateTime DateText { get; set; }

        /// <summary>
        /// Id магазина
        /// </summary>
        public int ShopId { get; set; }

        [ForeignKey("ShopId")]
        public Shop Shop { get; set; }
    }
}