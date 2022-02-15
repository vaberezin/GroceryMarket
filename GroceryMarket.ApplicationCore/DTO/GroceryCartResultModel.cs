using GroceryMarket.ApplicationCore.BaseClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroceryMarket.ApplicationCore.DTO
{
    public class GroceryCartResultModel
    {
        readonly decimal _sum;
        readonly IEnumerable<ProductBase> _products;        
        public GroceryCartResultModel()
        {
        }
        public GroceryCartResultModel(decimal sum, IEnumerable<ProductBase> products)
        {
            _sum = sum;
            _products = products;
        }
    }
}
