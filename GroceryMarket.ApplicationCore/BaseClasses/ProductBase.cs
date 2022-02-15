using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GroceryMarket.ApplicationCore.Interfaces;

namespace GroceryMarket.ApplicationCore.BaseClasses
{
    public abstract class ProductBase 
    {
        public abstract string Name { get; set; }
        public abstract decimal Cost { get; set; }
    }
}
