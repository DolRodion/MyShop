using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MyWorkShop.Entities;

namespace MyWorkShop.AppData
{
    public class DbWorkShopContext : DbContext
    {

        public DbWorkShopContext(DbContextOptions<DbWorkShopContext> option) : base(option) { }

        /// <summary>
        /// Сущность тестовой таблицы
        /// </summary>
        public DbSet<TestTable> TestTables { get; set; }

        /// <summary>
        /// Сущность магазина
        /// </summary>
        public DbSet<Shop> Shops { get; set; }

        /// <summary>
        /// Сущность товаров
        /// </summary>
        public DbSet<ShopProducts> ShopProducts { get; set; }

        /// <summary>
        /// Сущность покупок
        /// </summary>
        public DbSet<Purchases> Purchases { get; set; }

        /// <summary>
        /// Сущность покупателей
        /// </summary>
        public DbSet<Buyers> Buyers { get; set; }

        /// <summary>
        /// Скидки
        /// </summary>
        public DbSet<Discounts> Discounts { get; set; }

        /// <summary>
        /// Форум
        /// </summary>
        public DbSet<Forum> Forum { get; set; }

        /// <summary>
        /// Услуги
        /// </summary>
        public DbSet<ShopServices> ShopServices { get; set; }

        /// <summary>
        /// Заявки на услуги
        /// </summary>
        public DbSet<ServiceApplication> ServiceApplication { get; set; }

        /// <summary>
        /// Файл
        /// </summary>
        public DbSet<Files> File { get; set; }

        /// <summary>
        /// Журнал событий
        /// </summary>
        public DbSet<TransactionLog> TransactionLog { get; set; }

    }
}
