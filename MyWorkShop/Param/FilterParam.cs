using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyWorkShop.Param
{
    public class FilterParam
    {
        public string Manufacturer { get; set; }

        public int? PriceFrom { get; set; }

        public int? PriceBefore { get; set; }

        public bool Avaliable { get; set; }
    }
}
