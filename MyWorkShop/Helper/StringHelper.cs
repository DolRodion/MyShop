using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyWorkShop.Entities;

namespace MyWorkShop.Helper
{
    public static class StringHelper
    {
        public static string GetFioBuyer(this Buyers buyers)
        {
            if (buyers == null)
            {
                return string.Empty;
            }

            return $"{buyers.SurName} {buyers.FirstName} {buyers.Patronymic}";
        }
    }
}
