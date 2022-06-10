using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyWorkShop.Enums;
using MyWorkShop.Param;

namespace MyWorkShop.Interfaces
{
    interface ISaveLog
    {
        Task SaveLog(SaveLogParam? param, OperationEnum operationEvent, ApplicationException? exception);
    }
}
