using GroceryMarket.ApplicationCore.BaseClasses;
using GroceryMarket.ApplicationCore.Interfaces;
using GroceryMarket.Infrastructure.Implementations;
using GroceryMarket.Infrastructure.Implementations.ProductRules;
using GroceryMarket.Infrastructure.Implementations.RuleExecutors;
using GroceryMarket.Infrastructure.ServiceImplementations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace GroceryMarket.UnitTest.AppLogic
{
    public class PricingServiceTests
    {
        [Fact]
        public void GroceryPricingServiceGetCostPositive()
        {
            //Arrange
            GroceryPricing service = new GroceryPricing();
            GroceryRuleExecutor executor = new GroceryRuleExecutor();
            List<ProductBase> products = new List<ProductBase>();
            List<IRule> productRules = new List<IRule>();

            IRule ruleA = new ProductARule();
            IRule ruleC = new ProductCRule();

            productRules.AddRange(new List<IRule> { ruleA, ruleC });

            ProductA p1 = new ProductA();
            ProductA p2 = new ProductA();
            ProductA p3 = new ProductA();
            ProductA p4 = new ProductA();
            ProductA p5 = new ProductA();
            ProductA p6 = new ProductA();
            ProductA p7 = new ProductA();
            ProductA p8 = new ProductA();
            // 6 * 1 + 2 * 1.25 =  6 + 2.5 = 8.5
            ProductB p11 = new ProductB();
            ProductB p12 = new ProductB();
            ProductB p13 = new ProductB();
            // 4.25 * 3 = 12.75
            ProductC p21 = new ProductC();
            ProductC p22 = new ProductC();
            ProductC p23 = new ProductC();
            ProductC p24 = new ProductC();
            ProductC p25 = new ProductC();
            ProductC p26 = new ProductC();
            ProductC p27 = new ProductC();
            // 6 - 1/6*6 + 1 * 1 = 6 
            ProductD p31 = new ProductD();
            ProductD p32 = new ProductD();
            ProductD p33 = new ProductD();           
            // 0.75 * 3 = 2.25
            products.AddRange(new List<ProductA> { p1, p2, p3, p4, p5, p6, p7, p8 });
            products.AddRange(new List<ProductB> { p11, p12, p13});
            products.AddRange(new List<ProductC> { p21, p22, p23, p24, p25, p26, p27});
            products.AddRange(new List<ProductD> { p31, p32, p33});

            //Act
            // 8.5+ 6 + 2.25 + 12.75 = 15.5 + 15 = 29.5
            var result = service.GetCost(products, productRules, executor);

            //Assert
            Assert.Equal(29.5m, result);
        }

        [Fact]
        public void GroceryPricingServiceGetCostZeroPproductsrResultZero()
        {
            //Arrange
            GroceryPricing service = new GroceryPricing();
            GroceryRuleExecutor executor = new GroceryRuleExecutor();
            List<ProductBase> products = new List<ProductBase>();
            List<IRule> productRules = new List<IRule>();

            IRule ruleA = new ProductARule();
            IRule ruleC = new ProductCRule();

            productRules.AddRange(new List<IRule> { ruleA, ruleC });

           
            //Act
            var result = service.GetCost(products, productRules, executor);

            //Assert
            Assert.Equal(0m, result);
        }
    }
}
