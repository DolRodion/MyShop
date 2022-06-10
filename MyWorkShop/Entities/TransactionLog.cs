using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using MyWorkShop.Enums;

namespace MyWorkShop.Entities
{
    public class TransactionLog: BaseEntity
    {
        /// <summary>
        /// Дата операции
        /// </summary>
        public DateTime OperationDate { get; set; }

        /// <summary>
        /// Вид события
        /// </summary>
        public OperationEnum OperationEnum { get; set; }

        /// <summary>
        /// Сообщение
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// Пользователь
        /// </summary>
        public string Fio { get; set; }

        /// <summary>
        /// ID магазина
        /// </summary>
        public int ShopId { get; set; }

        [ForeignKey("ShopId")]
        public Shop Shop { get; set; }

        /// <summary>
        /// ID файла
        /// </summary>
        public int? FilesId { get; set; }

        [ForeignKey("FilesId")]
        public Files Files { get; set; }
    }
}
