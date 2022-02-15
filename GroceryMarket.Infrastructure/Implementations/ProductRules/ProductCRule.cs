using GroceryMarket.ApplicationCore.Interfaces;
using GroceryMarket.Infrastructure.Implementations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroceryMarket.Infrastructure.Implementations.ProductRules
{
    public class ProductCRule : IRule
    {
        public string ProductType { get; set; } = typeof(ProductC).Name;
        public int Count { get; set; } = 6;
        public decimal DiscountPerItem { get; set; } = 1/6m;
    }
}
