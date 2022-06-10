using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyWorkShop.Enums;
using MyWorkShop.Models;
using MyWorkShop.Param;

namespace MyWorkShop.Interfaces
{
    public interface ITransactionLogService
    {
        Task AddTransactionLogAsync(SaveLogParam? param, OperationEnum operationEvent, ApplicationException? exception);
        Task<List<TransactionLogModel>> GetAllTransactionLogModelAsync();
    }
}
