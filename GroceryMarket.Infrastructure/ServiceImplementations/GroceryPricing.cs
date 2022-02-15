using GroceryMarket.ApplicationCore.BaseClasses;
using GroceryMarket.ApplicationCore.Interfaces;
using GroceryMarket.ApplicationCore.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroceryMarket.Infrastructure.ServiceImplementations
{
    public class GroceryPricing : IPricingService
    {
        public decimal GetCost(List<ProductBase> products, IEnumerable<IRule> productRules, IRulable ruleExecutor)  
            // Take list of products. then uses rules for every product type (if rule exists) to calculate discount
        {
            List<IBill> bills = new List<IBill>();
            decimal clientBill = 0m;

            // Take a list of products of the same type for the current rule.            
            foreach (var rule in productRules)
            {
                var filteredProductList = products.Where(p => p.Name == rule.ProductType).ToList();
                if (filteredProductList.Count == 0)
                {
                    continue;
                }
                var specificBill = ruleExecutor.ExecuteRule(filteredProductList, rule);                     
                bills.Add(specificBill);
            }

            // Calculate final bill. 
            clientBill = products.Sum(p => p.Cost) - bills.Sum(b => b.ProductDiscount);

            if (products.Count == 0)
            {
                return 0;
            }
            return clientBill;
        }
    }
}
