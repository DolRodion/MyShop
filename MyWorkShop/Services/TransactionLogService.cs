using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using MyWorkShop.Const;
using MyWorkShop.Entities;
using MyWorkShop.Enums;
using MyWorkShop.Interfaces;
using MyWorkShop.Models;
using MyWorkShop.Param;

namespace MyWorkShop.Services
{
    public class TransactionLogService : ITransactionLogService
    {
        private readonly IGenericRepository<TransactionLog> _transactionLogRepository;
        private readonly IGenericRepository<Files> _filesRepository;
        private readonly IHostingEnvironment _hostingEnvironment;


        public TransactionLogService(IGenericRepository<TransactionLog> genericRepository,
            IGenericRepository<Files> filesRepository,
            IHostingEnvironment hostingEnvironment
            )
        {
            _transactionLogRepository = genericRepository;
            _filesRepository = filesRepository;
            _hostingEnvironment = hostingEnvironment;
        }

        public async Task AddTransactionLogAsync(SaveLogParam? param, OperationEnum operationEvent, ApplicationException? exception)
        {
            TransactionLog transactionLog = new TransactionLog();

            if (exception == null)
            {
                transactionLog.Fio = param.Fio;
                transactionLog.OperationDate = param.OperationDate;
                transactionLog.Message = param.Data;
                transactionLog.OperationEnum = operationEvent;
                transactionLog.ShopId = 1;
            }
            else
            {
                transactionLog.OperationDate = DateTime.Now;
                transactionLog.Fio = "Admin";
                transactionLog.ShopId = 1;
                transactionLog.OperationEnum = operationEvent;
                transactionLog.Message = StringConst.ErrorMessage;
                transactionLog.FilesId = await GenerateStackTraceFileAsync(exception);
            }

            await _transactionLogRepository.AddAsync(transactionLog);
        }

        private async Task<int> GenerateStackTraceFileAsync(ApplicationException exception)
        {
            Guid guid = Guid.NewGuid();
            string UniquefileName = guid.ToString() + ".txt";

            string path = "/log/" + UniquefileName;

            var text = exception.Message + exception.StackTrace;

            // запись в файл
            using (FileStream fstream = new FileStream(_hostingEnvironment.WebRootPath + path, FileMode.OpenOrCreate))
            {
                // преобразуем строку в байты
                byte[] array = System.Text.Encoding.Default.GetBytes(text);
                // запись массива байтов в файл
                fstream.Write(array, 0, array.Length);
            }

            var fileEntity = new Files()
            {
                FileName = StringConst.FileLogName,
                FilePatch = path,
                UniqueName = guid
            };

            await _filesRepository.AddAsync(fileEntity);

            return fileEntity.Id;
        }

        public async Task<List<TransactionLogModel>> GetAllTransactionLogModelAsync()
        {
            var entity = await _transactionLogRepository.AsQueryable()
               .OrderByDescending(s => s.Id)
               .ToListAsync();

            List<TransactionLogModel> result = new List<TransactionLogModel>();

            foreach (var item in entity)
            {
                result.Add(
                    new TransactionLogModel()
                    {
                        OperationDate = item.OperationDate,
                        Fio = item.Fio,
                        Data = item.Message,
                        Id = item.Id,
                        OperationEnum = item.OperationEnum,
                    }
                ) ;
            }
            return result;
        }

    }
}
