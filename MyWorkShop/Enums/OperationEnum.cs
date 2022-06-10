using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace MyWorkShop.Enums
{
    public enum OperationEnum
    {
        [Description("Редактирование товара")]
        CorrectProduct = 1,

        [Description("Добавление товара")]
        AddProduct = 2,
    }
}
