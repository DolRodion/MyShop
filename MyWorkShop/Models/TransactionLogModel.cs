using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyWorkShop.Enums;

namespace MyWorkShop.Models
{
    public class TransactionLogModel
    {
        /// <summary>
        /// Id лога
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Вид события
        /// </summary>
        public OperationEnum OperationEnum { get; set; }

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
