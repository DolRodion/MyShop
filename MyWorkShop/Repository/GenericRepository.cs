using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MyWorkShop.AppData;
using MyWorkShop.Entities;
using MyWorkShop.Interfaces;

namespace MyWorkShop.Repository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : BaseEntity
    {
        private readonly DbWorkShopContext _dbWorkShopContext;

        public GenericRepository(DbWorkShopContext dbWorkShopContext)
        {
            _dbWorkShopContext = dbWorkShopContext;
        }

        /// <summary>
        /// Метод получения всех данных с таблицы
        /// </summary>
        /// <returns></returns>
        public async Task<List<T>> GetAllAsync()
        {
            return await _dbWorkShopContext.Set<T>().ToListAsync();
        }

        /// <summary>
        /// Метод получения данных по Id
        /// </summary>
        /// <returns></returns>
        public async Task<T> GetByIdAsync(int? id)
        {
            return await _dbWorkShopContext.Set<T>().FindAsync(id);
        }

        /// <summary>
        /// Получение сущности через AsQueryable
        /// </summary>
        public IQueryable<T> AsQueryable()
        {
            return _dbWorkShopContext.Set<T>().AsQueryable();
        }

        /// <summary>
        /// Запрос на удаление выбранной записи по ID
        /// </summary>
        public async Task DeleteAsync(int? id)
        {
            T entity = await GetByIdAsync(id);
            if (entity != null)
            {
                _dbWorkShopContext.Set<T>().Remove(entity);
                await _dbWorkShopContext.SaveChangesAsync();
            }
        }

        /// <summary>
        /// Запрос на добавление новой записи
        /// </summary>
        public async Task AddAsync(T entity)
        {
            await _dbWorkShopContext.AddAsync(entity);
            await _dbWorkShopContext.SaveChangesAsync();
        }

        /// <summary>
        /// Обновление БД
        /// </summary>
        public async Task SaveChangesAsync()
        {
            await _dbWorkShopContext.SaveChangesAsync();
        }

    }
}
