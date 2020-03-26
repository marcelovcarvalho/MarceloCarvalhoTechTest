using System;
using System.Collections.Generic;
using System.Linq;

namespace IntuitionTest.Question3
{
    public class CartTotal : ICartTotal
    {
        public double Calculate(IEnumerable<Product> products, ILocalizationInfo localInfo)
        {
            double total = products.Sum(p => p.Price);
            double taxRate = localInfo.getTaxRate();

            total += (total * taxRate);
            return total;
        }

    }
}
