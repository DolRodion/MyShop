using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyWorkShop.Models
{
    public class ForumMessegeModel
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
    }
}
