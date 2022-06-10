using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace MyWorkShop.Enums
{
    public enum TypeProductsEnum
    {
        [Description("Клава")]
        Klava = 1,

        [Description("Ноуты")]
        Noyt = 2,

        [Description("Колонка")]
        Kolonka = 3,

        [Description("Мышки")]
        Mouse = 4,

        [Description("Мониторы")]
        Monitor = 5,

        [Description("Не определено")]
        Undefined = 6,
    }
}
