using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroceryMarket.ApplicationCore.Interfaces
{
    public interface IRule  // describes discount possibility. Should interact with number of products in ICalculatable through implemented rule class. 
    {
        public string ProductType { get; set; } // should be hardcoded, used for mapping ProductRule to Product
        public int Count { get; set; }
        public decimal DiscountPerItem { get; set; }
    }
}
