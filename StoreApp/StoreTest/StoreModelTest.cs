using System;
using Xunit;
using StoreModels;

namespace StoreTest
{
    public class StoreModelTest
    {
        private Customer testCustomer = new Customer();
        private Item testItem = new Item();
        private Location testLocation = new Location();
        private Order testOrder = new Order();
        private Product testProduct = new Product();
        [Fact]
        public void CustomerNameShouldBeSet()
        {
            string testName = "Koolaid-Man";
            //Act
            testCustomer.CustomerName = testName;
            //Assert
            Assert.Equal(testName, testCustomer.CustomerName);
        }
         public void CustomerAddressShouldBeSet()
        {
            string testName = "The Boulevard of Broken Dreams";
            //Act
            testCustomer.CustomerAddress = testName;
            //Assert
            Assert.Equal(testName, testCustomer.CustomerAddress);
        }
         public void LocationNameShouldBeSet()
        {
            string testName = "New Location";
            //Act
            testLocation.LocationName = testName;
            //Assert
            Assert.Equal(testName, testLocation.LocationName);
        }
         public void LocationAddressShouldBeSet()
        {
            string testName = "New Location Street";
            //Act
            testLocation.StreetAddress = testName;
            //Assert
            Assert.Equal(testName, testLocation.StreetAddress);
        }
            public void OrderTotalShouldBeSet()
        {
            decimal testTotal = 1000;
            //Act
            testOrder.OrderTotal = testTotal;
            //Assert
            Assert.Equal(testTotal, testOrder.OrderTotal);
        }
          public void OrderQuantity1ShouldBeSet()
        {
            int testQty = 100;
            //Act
            testOrder.OrderQuantity1 = testQty;
            //Assert
            Assert.Equal(testQty, testOrder.OrderQuantity1);
        }
           public void OrderQuantity2ShouldBeSet()
        {
            int testQty = 100;
            //Act
            testOrder.OrderQuantity2 = testQty;
            //Assert
            Assert.Equal(testQty, testOrder.OrderQuantity2);
        }
           public void OrderQuantity3ShouldBeSet()
        {
            int testQty = 100;
            //Act
            testOrder.OrderQuantity3 = testQty;
            //Assert
            Assert.Equal(testQty, testOrder.OrderQuantity3);
        }
          public void ProductNameShouldBeSet()
        {
            string testName = "Crackers";
            //Act
            testProduct.ProductName = testName;
            //Assert
            Assert.Equal(testName, testProduct.ProductName);
        }
           public void ProductPriceShouldBeSet()
        {
            decimal testPrice = 1000;
            //Act
            testProduct.Price = testPrice;
            //Assert
            Assert.Equal(testPrice, testProduct.Price);
        }
         public void CustomerNameShouldNotBeEmpty(string testName)
        {
            //Act and Assert
            Assert.Throws<ArgumentNullException>(() => testCustomer.CustomerName = testName);
        }
         public void CustomerAddressShouldNotBeEmpty(string testName)
        {
            //Act and Assert
            Assert.Throws<ArgumentNullException>(() => testCustomer.CustomerAddress = testName);
        }
         public void LocationNameShouldNotBeEmpty(string testName)
        {
            //Act and Assert
            Assert.Throws<ArgumentNullException>(() => testLocation.LocationName = testName);
        }
          public void LocationAddressShouldNotBeEmpty(string testName)
        {
            //Act and Assert
            Assert.Throws<ArgumentNullException>(() => testLocation.StreetAddress = testName);
        }
         public void OrderTotalShouldNotBeEmpty(decimal testTotal)
        {
            //Act and Assert
            Assert.Throws<ArgumentNullException>(() => testOrder.OrderTotal = testTotal);
        }
         public void OrderQuantiy1lShouldNotBeEmpty(int testQty)
        {
            //Act and Assert
            Assert.Throws<ArgumentNullException>(() => testOrder.OrderQuantity1 = testQty);
        }
         public void OrderQuantiy12ShouldNotBeEmpty(int testQty)
        {
            //Act and Assert
            Assert.Throws<ArgumentNullException>(() => testOrder.OrderQuantity2 = testQty);
        }
         public void OrderQuantiy3lShouldNotBeEmpty(int testQty)
        {
            //Act and Assert
            Assert.Throws<ArgumentNullException>(() => testOrder.OrderQuantity3 = testQty);
        }
         public void ProductNameShouldNotBeEmpty(string testName)
        {
            //Act and Assert
            Assert.Throws<ArgumentNullException>(() => testProduct.ProductName = testName);
        }
         public void ProductPriceShouldNotBeEmpty(decimal testPrice)
        {
            //Act and Assert
            Assert.Throws<ArgumentNullException>(() => testProduct.Price = testPrice);
        }
    }
}
