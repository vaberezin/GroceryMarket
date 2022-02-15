using GroceryMarket.ApplicationCore.BaseClasses;
using GroceryMarket.ApplicationCore.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroceryMarket.ApplicationCore.Interfaces
{
    public interface ICalculatable
    {
        public decimal Calculate(IPricingService service, List<ProductBase> products, IEnumerable<IRule> productRules, IRulable ruleExecutor);
    }
}
