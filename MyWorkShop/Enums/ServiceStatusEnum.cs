using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace MyWorkShop.Enums
{
    public enum ServiceStatusEnum
    {
        [Description("В рассмотрении")]
        InConsideration = 1,

        [Description("Рассмотрено")]
        Reviewed = 2,

        [Description("Завершено")]
        Completed = 3,

        [Description("Отказ клиента")]
        СlientReject = 4,

        [Description("Отказ фирмы")]
        СompanyReject = 5,
    }
}
