using GroceryMarket.ApplicationCore.Interfaces;
using GroceryMarket.Infrastructure.Implementations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroceryMarket.Infrastructure.Implementations.ProductRules
{
    public class ProductARule : IRule
    {        
        public string ProductType { get; set; } = typeof(ProductA).Name;
        public int Count { get; set; } = 3;
        public decimal DiscountPerItem { get; set; } = 0.25m;
    }
}
