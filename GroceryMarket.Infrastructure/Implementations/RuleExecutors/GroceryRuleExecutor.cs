using GroceryMarket.ApplicationCore.BaseClasses;
using GroceryMarket.ApplicationCore.Interfaces;
using GroceryMarket.Infrastructure.Implementations.Bills;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroceryMarket.Infrastructure.Implementations.RuleExecutors
{
    public class GroceryRuleExecutor : IRulable
    {
        // takes a list of products of the same type for rule and executes it. The logic of this executor is the same for every rule.
        public IBill ExecuteRule(List<ProductBase> products, IRule rule) 
        {            
            // returns amount of discount
            int timesDiscountIsApplicable = products.Count / rule.Count;            

            return new GroceryBillModel
            {
                ProductName = rule.ProductType,
                ProductDiscount = Math.Round((timesDiscountIsApplicable * rule.Count * rule.DiscountPerItem), 2),
                ProductBillWithoutDiscount = products.First().Cost * products.Count                
            };
        }
    }
}
