using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using MyWorkShop.Enums;

namespace MyWorkShop.Entities
{
    public class ServiceApplication : BaseEntity
    {
        /// <summary>
        /// Дата создания заявки
        /// </summary>
        public DateTime ApplicationData { get; set; }
        
        /// <summary>
        /// Дата оказания услуги
        /// </summary>
        public DateTime? ServiceDeliveryDate { get; set; }

        /// <summary>
        /// Статус заявки
        /// </summary>
        public ServiceStatusEnum ServiceStatusEnum { get; set; }

        /// <summary>
        /// Фио клиента
        /// </summary>
        public string Fio { get; set; }

        /// <summary>
        /// Телефон клиента
        /// </summary>
        public string Telephone { get; set; }

        /// <summary>
        /// Email клиента
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Комментарий
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Id услуги
        /// </summary>
        public int ShopServicesId { get; set; }

        [ForeignKey("ShopServicesId")]
        public ShopServices ShopServices { get; set; }
    }
}
