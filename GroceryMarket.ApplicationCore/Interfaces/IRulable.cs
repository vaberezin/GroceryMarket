using GroceryMarket.ApplicationCore.BaseClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroceryMarket.ApplicationCore.Interfaces
{
    public interface IRulable  //decribes rule execution ability.
    {
        public IBill ExecuteRule(List<ProductBase> products, IRule rule);
    }
}
