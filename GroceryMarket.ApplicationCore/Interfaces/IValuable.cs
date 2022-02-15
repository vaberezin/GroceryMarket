using GroceryMarket.ApplicationCore.BaseClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroceryMarket.ApplicationCore.Interfaces
{
    public interface IValuable // enables product evaluation
    {
        public decimal GetCost(List<ProductBase> products, IEnumerable<IRule> productRules, IRulable ruleExecutor);
    }
}
