using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GroceryMarket.ApplicationCore.BaseClasses;

namespace GroceryMarket.Infrastructure.Implementations
{
    public class ProductD : ProductBase
    {
        public override string Name { get; set; } = typeof(ProductD).Name;
        public override decimal Cost { get; set; } = 0.75m;
    }
}
