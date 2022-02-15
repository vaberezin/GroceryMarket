using GroceryMarket.ApplicationCore.BaseClasses;
using GroceryMarket.Infrastructure.Implementations;
using GroceryMarket.Infrastructure.Implementations.RuleExecutors;
using System.Collections.Generic;
using System.Collections;
using Xunit;
using GroceryMarket.ApplicationCore.Interfaces;
using GroceryMarket.Infrastructure.Implementations.ProductRules;

namespace GroceryMarket.UnitTest.AppLogic
{
    public class RuleExecutorTests
    {
        [Fact]
        public void GroceryRuleExecutorProductBillResultProductDiscount()
        {
            //Arrange
            GroceryRuleExecutor executor = new GroceryRuleExecutor();
            List<ProductBase> products = new List<ProductBase>();
            IRule ruleA = new ProductARule();

            ProductA p1 = new ProductA();
            ProductA p2 = new ProductA();
            ProductA p3 = new ProductA();
            ProductA p4 = new ProductA();
            ProductA p5 = new ProductA();
            ProductA p6 = new ProductA();
            ProductA p7 = new ProductA();
            ProductA p8 = new ProductA();

            products.AddRange(new List<ProductA> { p1, p2, p3, p4, p5, p6, p7, p8});

            //Act
            var result = executor.ExecuteRule(products, ruleA);

            //Assert
            Assert.Equal(1.5m, result.ProductDiscount);
        }

        [Fact]
        public void GroceryRuleExecutorProductBillResultProductBillWithoutDiscount()
        {
            //Arrange
            GroceryRuleExecutor executor = new GroceryRuleExecutor();
            List<ProductBase> products = new List<ProductBase>();
            IRule ruleA = new ProductARule();

            ProductA p1 = new ProductA();
            ProductA p2 = new ProductA();
            ProductA p3 = new ProductA();
            ProductA p4 = new ProductA();
            ProductA p5 = new ProductA();
            ProductA p6 = new ProductA();
            ProductA p7 = new ProductA();
            ProductA p8 = new ProductA();

            products.AddRange(new List<ProductA> { p1, p2, p3, p4, p5, p6, p7, p8 });

            //Act
            var result = executor.ExecuteRule(products, ruleA);

            //Assert
            Assert.Equal(10.0m, result.ProductBillWithoutDiscount);
        }

        [Fact]
        public void GroceryRuleExecutorProductBillResultProductName()
        {
            //Arrange
            GroceryRuleExecutor executor = new GroceryRuleExecutor();
            List<ProductBase> products = new List<ProductBase>();
            IRule ruleA = new ProductARule();

            ProductA p1 = new ProductA();
            ProductA p2 = new ProductA();
            ProductA p3 = new ProductA();
            ProductA p4 = new ProductA();
            ProductA p5 = new ProductA();
            ProductA p6 = new ProductA();
            ProductA p7 = new ProductA();
            ProductA p8 = new ProductA();

            products.AddRange(new List<ProductA> { p1, p2, p3, p4, p5, p6, p7, p8 });

            //Act
            var result = executor.ExecuteRule(products, ruleA);

            //Assert
            Assert.Equal("ProductA", result.ProductName);
        }
    }
}
