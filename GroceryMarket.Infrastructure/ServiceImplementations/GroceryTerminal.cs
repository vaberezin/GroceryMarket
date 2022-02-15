using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GroceryMarket.ApplicationCore.BaseClasses;
using GroceryMarket.ApplicationCore.Interfaces;
using GroceryMarket.ApplicationCore.Services;

namespace GroceryMarket.Infrastructure.ServiceImplementations
{
    public class GroceryTerminal : ITerminalService
    {
        public decimal Calculate(IPricingService service, List<ProductBase> products, IEnumerable<IRule> productRules, IRulable ruleExecutor)
        {            
            return service.GetCost(products, productRules, ruleExecutor);
        }
    }
}
