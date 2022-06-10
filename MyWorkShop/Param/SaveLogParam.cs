using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyWorkShop.Param
{
    public class SaveLogParam
    {
        /// <summary>
        /// Дата операции
        /// </summary>
        public DateTime OperationDate { get; set; }
  
        /// <summary>
        /// Данные
        /// </summary>
        public string Data { get; set; } 

        /// <summary>
        /// Пользователь
        /// </summary>
        public string Fio { get; set; } 
    }
}
