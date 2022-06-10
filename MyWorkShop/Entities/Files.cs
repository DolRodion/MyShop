using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyWorkShop.Entities
{
    public class Files : BaseEntity
    {
        /// <summary>
        /// Название файла
        /// </summary>
        public string FileName { get; set; }

        /// <summary>
        /// Путь к файлу
        /// </summary>
        public string FilePatch { get; set; }

        /// <summary>
        /// Guid
        /// </summary>
        public Guid UniqueName { get; set; }

        /// <summary>
        /// Навигационное свойство
        /// </summary>
        public ShopProducts ShopProducts { get; set; }
    }
}
