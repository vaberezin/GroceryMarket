using GroceryMarket.ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroceryMarket.Infrastructure.Implementations.Bills
{
    public class GroceryBillModel : IBill
    {
        public string ProductName { get; set; }
        public decimal ProductDiscount { get; set; }
        public decimal ProductBillWithoutDiscount { get; set; }
    }
}
