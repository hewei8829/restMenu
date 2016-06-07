using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MenuService.Contract.Enums
{
    public class Price
    {
        public string Size { get; set; }

        public double UnitPrice { get; set; }

        public double DiscountPrice { get; set; }

    }
}
