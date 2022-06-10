using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using MyWorkShop.Enums;

namespace MyWorkShop.Helper
{
    public static class EnumHelper
    {
        
        public static string GetDescription<T>(this T source)
        {
            
            FieldInfo fi = source.GetType().GetField(source.ToString());

            DescriptionAttribute[] attributes = (DescriptionAttribute[])fi.GetCustomAttributes(
                typeof(DescriptionAttribute), false);

            if (attributes != null && attributes.Length > 0) return attributes[0].Description;
            else return source.ToString();
            
        }

        public static TypeProductsEnum GetTypeProductsEnum(string enumString)
        {
            switch (enumString)
            {
                case "Клава": return TypeProductsEnum.Klava;
                case "Ноуты": return TypeProductsEnum.Noyt;
                case "Колонка": return TypeProductsEnum.Kolonka;
                case "Мышки": return TypeProductsEnum.Mouse;
                case "Мониторы": return TypeProductsEnum.Monitor;
            }
            return TypeProductsEnum.Undefined;
        }


    }
}
