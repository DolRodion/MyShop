using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyWorkShop.Models
{
    public class ShortShopServiceModel
    {
        public int Id { get; set; }

        public string ServiceName { get; set; }

        public decimal ServicePrice { get; set; }

        public string DescriptionService { get; set; }
    }
}
