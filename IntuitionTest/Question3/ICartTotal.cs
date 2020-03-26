using System.Collections.Generic;

namespace IntuitionTest.Question3
{
    public interface ICartTotal
    {
        double Calculate(IEnumerable<Product> products, ILocalizationInfo localInfo);
    }
}
