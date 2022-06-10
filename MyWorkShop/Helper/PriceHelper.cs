using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyWorkShop.Entities;

namespace MyWorkShop.Helper
{
    public static class PriceHelper
    {
        public static decimal GetPriceWithDiscount(decimal price, Discounts discount)
        {
            return discount.DiscountAvailability ? price - (price / 100) * discount.Discount : price;
        }

        public static int IsDiscountExpired(Discounts discount)
        {
            //Если скидки нет
            if (discount == null) return 0;

            //Если скидка не просрочена
            if (discount.DiscountAvailability)
            {
                return discount.Discount;
            }
            else
            {
                return 0;   //Если скидка просрочена
            }
        }
    }
}
