using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using CowboyCafe.Data;
using System.ComponentModel;
namespace CowboyCafe.DataTests.UnitTests
{
    public class OrderTests
    {

        public class MockOrderItem : IOrderItem
        {
            public double Price { get; set; }
            public List<string> SpecialInstructions { get; set; }



        }
        //should be able to add items
        [Fact]
        public void ShouldBeAbleToAddItems()
        {
            var order = new Order();
            var item = new MockOrderItem();
            order.Add(item);
            Assert.Contains(item, order.Items);
        }
        //should be able to remove items
        [Fact]
        public void ShouldBeAbleToRemoveItems()
        {
            var order = new Order();
            var item = new MockOrderItem();
            order.Add(item);
            order.Remove(item);
            Assert.DoesNotContain(item, order.Items);

        }
        //should be able to get the list of items
        [Fact]
        public void ShouldBeAbleToGetAnEnumerationOfItems()
        {
            var order = new Order();
            var item0 = new MockOrderItem();
            var item1 = new MockOrderItem();
            var item2 = new MockOrderItem();
            order.Add(item0);
            order.Add(item1);
            order.Add(item2);
            Assert.Collection(order.Items,
                item => Assert.Equal(item0, item),
                item => Assert.Equal(item1, item),
                item => Assert.Equal(item2, item)
                );

        }

        //subtotal should be sum of item priecs
        [Theory]
        [InlineData(new double[] { 1, 2, 3 })]
        [InlineData(new double[] { 0, 0, 0 })]
        [InlineData(new double[] { 199, 799 })]
        [InlineData(new double[] { 798 })]
        [InlineData(new double[] { })]
        [InlineData(new double[] { -5 })]
        [InlineData(new double[] { -4, 10, 8 })]
        [InlineData(new double[] { 3.13457890 })]
        [InlineData(new double[] { double.NaN })]

        public void SubtotalShouldBeSumOfAllItemPrices(double[] prices)
        {
            var order = new Order();
            double total = 0;
            foreach (var price in prices)
            {
                total += price;
                order.Add(new MockOrderItem() {
                    Price = price
                });
            }
            Assert.Equal(total, order.Subtotal);
        }
        
        

    }
}
