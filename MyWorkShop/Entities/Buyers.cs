using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyWorkShop.Entities
{
    public class Buyers : BaseEntity 
    {
        /// <summary>
        /// Имя покупателя
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Фамилия покупателя
        /// </summary>
        public string SurName { get; set; }

        /// <summary>
        /// Отчество покупателя
        /// </summary>
        public string Patronymic { get; set; }
    }
}
