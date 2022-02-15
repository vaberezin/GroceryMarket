using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroceryMarket.ApplicationCore.Interfaces
{
    // Describes an abstract bill
    public interface IBill
    {
        public string ProductName { get; set; }
        public decimal ProductDiscount { get; set; }
        public decimal ProductBillWithoutDiscount { get; set; }
    }
}
